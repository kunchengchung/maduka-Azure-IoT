using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;
using System.Data.SqlClient;
using Microsoft.WindowsAzure.Storage.Blob;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;
using Microsoft.WindowsAzure.Storage;
using Newtonsoft.Json;

namespace JobProcessor
{

    class IoTProcessor : IEventProcessor
    {
        public static string StorageConnectionString { get; set; }
        public static string ServiceBusConnectionString { get; set; }

        private CloudBlobClient blobClient;
        private CloudBlobContainer blobContainer;
        private QueueClient queueClient;

        private long currentBlockInitOffset;
        private const int MAX_BLOCK_SIZE = 4 * 1024;// * 1024;
        private MemoryStream toAppend = new MemoryStream(MAX_BLOCK_SIZE);

        private Stopwatch stopwatch;
        private TimeSpan MAX_CHECKPOINT_TIME = TimeSpan.FromSeconds(5);

        Models.IoTDbEntities objDb = new Models.IoTDbEntities();

        /// <summary>
        /// 初始化IoTProcessor的動作
        /// </summary>
        public IoTProcessor()
        {
            // 定義要將檢查點存放的Blob位置
            var storageAccount = CloudStorageAccount.Parse(StorageConnectionString);
            blobClient = storageAccount.CreateCloudBlobClient();
            blobContainer = blobClient.GetContainerReference("d2ctutorial");
            blobContainer.CreateIfNotExists();
        }

        /// <summary>
        /// 關閉Processor的動作
        /// </summary>
        /// <param name="context"></param>
        /// <param name="reason"></param>
        /// <returns></returns>
        public Task CloseAsync(PartitionContext context, CloseReason reason)
        {
            Console.WriteLine("IotProcessor Shutting Down. Partition '{0}', Reason: '{1}'.", context.Lease.PartitionId, reason);
            return Task.FromResult<object>(null);
        }

        /// <summary>
        /// 開啟Processor的動作
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Task OpenAsync(PartitionContext context)
        {
            Console.WriteLine("IoTProcessor initialized.  Partition: '{0}', Offset: '{1}'", context.Lease.PartitionId, context.Lease.Offset);

            if (!long.TryParse(context.Lease.Offset, out currentBlockInitOffset))
            {
                currentBlockInitOffset = 0;
            }

            stopwatch = new Stopwatch();
            stopwatch.Start();

            return Task.FromResult<object>(null);
        }

        /// <summary>
        /// 執行Processor的動作
        /// </summary>
        /// <param name="context"></param>
        /// <param name="messages"></param>
        /// <returns></returns>
        async Task IEventProcessor.ProcessEventsAsync(PartitionContext context, IEnumerable<EventData> messages)
        {
            foreach (EventData eventData in messages)
            {
                byte[] data = eventData.GetBytes();
                var text = Encoding.UTF8.GetString(data);

                if (text != "")
                {
                    // 在這裡把IoT Hub的資料抓出來, text就是從IoT Hub中取得的JSON資料字串
                    // 寫入到資料庫之中
                    Console.WriteLine(text);
                    Models.DeviceData objData = JsonConvert.DeserializeObject<Models.DeviceData>(text);
                    objDb.DeviceData.Add(objData);
                    objDb.SaveChanges();
                }

                // 寫入檢查點的動作，這一段也是放在foreach中直接貼上就可以
                if (toAppend.Length + data.Length > MAX_BLOCK_SIZE || stopwatch.Elapsed > MAX_CHECKPOINT_TIME)
                {
                    await AppendAndCheckpoint(context);
                }

                await toAppend.WriteAsync(data, 0, data.Length);

                Console.WriteLine(string.Format("Message received.  Partition: '{0}', Data: '{1}'",
                    context.Lease.PartitionId, Encoding.UTF8.GetString(data)));
            }
        }

        /// <summary>
        /// 於IoT Hub執行的過程中，寫入檢查點，避免重複讀取的動作
        /// 這裡只要直接複製貼上就可以執行
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task AppendAndCheckpoint(PartitionContext context)
        {
            var blockIdString = String.Format("startSeq:{0}", currentBlockInitOffset.ToString("0000000000000000000000000"));
            var blockId = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(blockIdString));
            toAppend.Seek(0, SeekOrigin.Begin);
            byte[] md5 = MD5.Create().ComputeHash(toAppend);
            toAppend.Seek(0, SeekOrigin.Begin);

            var blobName = String.Format("iothubd2c_{0}", context.Lease.PartitionId);
            var currentBlob = blobContainer.GetBlockBlobReference(blobName);

            if (await currentBlob.ExistsAsync())
            {
                await currentBlob.PutBlockAsync(blockId, toAppend, Convert.ToBase64String(md5));
                var blockList = await currentBlob.DownloadBlockListAsync();
                var newBlockList = new List<string>(blockList.Select(b => b.Name));

                if (newBlockList.Count() > 0 && newBlockList.Last() != blockId)
                {
                    newBlockList.Add(blockId);
                    Console.WriteLine(String.Format("Appending block id: {0} to blob: {1}", blockIdString, currentBlob.Name));
                }
                else
                {
                    Console.WriteLine(String.Format("Overwriting block id: {0}", blockIdString));
                }
                await currentBlob.PutBlockListAsync(newBlockList);
            }
            else
            {
                await currentBlob.PutBlockAsync(blockId, toAppend, Convert.ToBase64String(md5));
                var newBlockList = new List<string>();
                newBlockList.Add(blockId);
                await currentBlob.PutBlockListAsync(newBlockList);

                Console.WriteLine(String.Format("Created new blob", currentBlob.Name));
            }

            toAppend.Dispose();
            toAppend = new MemoryStream(MAX_BLOCK_SIZE);

            // checkpoint.
            await context.CheckpointAsync();
            Console.WriteLine(String.Format("Checkpointed partition: {0}", context.Lease.PartitionId));

            currentBlockInitOffset = long.Parse(context.Lease.Offset);
            stopwatch.Restart();
        }
    }
}
