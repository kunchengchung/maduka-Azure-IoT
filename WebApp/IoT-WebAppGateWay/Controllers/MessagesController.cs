using Microsoft.Azure.Devices.Client;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using System.Configuration;

namespace IoT_WebAppGateWay.Controllers
{
    public class MessagesController : ApiController
    {
        static string iotHubUri = ConfigurationManager.AppSettings["IoTHubUrl"].ToString();
        static string redisCacheConnectionString = ConfigurationManager.ConnectionStrings["RedisCache"].ToString();

        // 開啟Redis Cache的連線
        private static Lazy<ConnectionMultiplexer> lazyConnection =
            new Lazy<ConnectionMultiplexer>(() => { return ConnectionMultiplexer.Connect(redisCacheConnectionString); });

        public static ConnectionMultiplexer objConn
        {
            get
            {
                return lazyConnection.Value;
            }
        }

        /// <summary>
        /// 發送訊息至IoT Hub
        /// </summary>
        /// <param name="value">發送物件</param>
        /// <returns>true:發送成功  false:發送失敗</returns>
        public async Task<HttpResponseMessage> Post(Models.Message value)
        {
            HttpStatusCode code = HttpStatusCode.OK;
            string strContent = "true";

            try
            {
                // 先確認快取中有沒有資料
                IDatabase objCache = objConn.GetDatabase();
                RedisValue objValue = objCache.StringGet(value.DeviceId);
                string strKey = (objValue.HasValue) ? objValue.ToString() : "";

                if (strKey == "")
                {
                    // 透過EF找出資料庫中該裝置的Key值
                    Models.DeviceFile objDevice = new Models.IoTModel().DeviceFile.FirstOrDefault(x => x.DeviceId == value.DeviceId);

                    if (objDevice != null)
                    {
                        strKey = objDevice.DeviceKey;
                        // 寫入快取資料
                        objCache.StringSet(value.DeviceId, strKey);
                    }
                }

                if (strKey != "")
                {
                    // 傳送訊息進入IoT Hub
                    DeviceClient deviceClient = null;
                    deviceClient = DeviceClient.CreateFromConnectionString
                    (
                        $"HostName={iotHubUri};DeviceId={value.DeviceId};SharedAccessKey={strKey}",
                        Microsoft.Azure.Devices.Client.TransportType.Amqp
                    );

                    await deviceClient.SendEventAsync(new Microsoft.Azure.Devices.Client.Message(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(value))));
                }
                else
                {
                    code = HttpStatusCode.NotFound;
                    strContent = "找不到該裝置，該裝置並無登錄於資料庫中";
                }

            }
            catch (Exception e)
            {
                code = HttpStatusCode.BadRequest;
                strContent = e.Message;
            }

            return Request.CreateResponse(code, strContent);
        }
    }
}
