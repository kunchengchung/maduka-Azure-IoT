using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;
using System.Data.SqlClient;
using Microsoft.Azure.NotificationHubs;

namespace JobServiceBusProcessor
{
    public class ServiceBusProcessor
    {
        private static string strServiceBusConnectinString = ConfigurationSettings.AppSettings["ServiceBusConnectionString"].ToString();
        private static string strQueueName = ConfigurationSettings.AppSettings["ServiceBusQueue"].ToString();
        private static string strNotificationConnectionString = ConfigurationSettings.AppSettings["NotificationConnectionString"].ToString();
        private static string strNotificationHubName = ConfigurationSettings.AppSettings["NotificationHubName"].ToString();

        //private static SqlCommand SqlCmd = new SqlCommand();
        //private static SqlConnection SqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());

        public static void LookupNotification()
        {
            // 開啟資料庫
            //SqlCmd.Connection = SqlConn;
            //SqlCmd.Connection.Open();

            // 取得Queue裡的資料
            QueueClient qc = QueueClient.CreateFromConnectionString(strServiceBusConnectinString, strQueueName);
            OnMessageOptions options = new OnMessageOptions();
            options.AutoComplete = false;
            options.AutoRenewTimeout = TimeSpan.FromMinutes(1);

            // Callback to handle received messages.
            qc.OnMessage((message) =>
            {
                try
                {
                    var o = message.GetBody<System.IO.Stream>();
                    using (var r = new StreamReader(o))
                    {
                        var msg = r.ReadToEnd();

                        msg = msg.Replace(@"@string3http://schemas.microsoft.com/2003/10/Serialization/�", "");
                        msg = msg.Substring(1, msg.Length - 1);

                        Models.SensorData obj = JsonConvert.DeserializeObject<Models.SensorData>(msg);

                        Console.WriteLine("Body: " + msg);
                        Console.WriteLine("MessageID: " + message.MessageId);

                        SendNotificationAsync("alert!!" + msg);

                        message.Complete();
                    }

                }
                catch (Exception exp)
                {
                    // Indicates a problem, unlock message in queue.
                    Console.WriteLine("EXCEPTION:" + exp.Message);
                    if (exp.InnerException != null)
                    {
                        Console.WriteLine("INNER:" + exp.Message);
                    }
                    if (exp.StackTrace != null)
                    {
                        Console.WriteLine($"Stack:{exp.StackTrace}");
                    }

                    message.Abandon();
                    //message.Complete();

                    //if (SqlCmd.Connection.State == System.Data.ConnectionState.Open)
                    //    SqlCmd.Connection.Close();
                }
            }, options);
        }

        private static async Task SendNotificationAsync(string msg)
        {
            // await SendWindowsNotificationAsync(msg);
            await SendAndroidNotificationAsync(msg);
        }
        private static async Task SendWindowsNotificationAsync(string msg)
        {
            NotificationHubClient hub = NotificationHubClient
                .CreateClientFromConnectionString(strNotificationConnectionString, strNotificationHubName);
            var toast = $"<toast launch=\"launch_arguments\"><visual><binding template=\"ToastText01\"><text id=\"1\">{msg}</text></binding></visual></toast>";
            var results = await hub.SendWindowsNativeNotificationAsync(toast);
        }
        private static async Task SendAndroidNotificationAsync(string msg)
        {
            NotificationHubClient hub = NotificationHubClient
                .CreateClientFromConnectionString(strNotificationConnectionString, strNotificationHubName);
            Newtonsoft.Json.Linq.JObject o = JsonConvert.DeserializeObject(msg) as Newtonsoft.Json.Linq.JObject;
            var toast = "{data:{message:'{device} alert at {time}'}}".Replace("{device}", (string)o["deviceid"]).Replace("{time}", (string)o["time"]);
            var results = await hub.SendGcmNativeNotificationAsync(toast);

        }
    }
}
