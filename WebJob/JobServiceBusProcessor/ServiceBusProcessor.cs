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
using SendGrid;
using SendGrid.Helpers.Mail;

namespace JobServiceBusProcessor
{
    public class ServiceBusProcessor
    {
        private static string strServiceBusConnectinString = ConfigurationManager.AppSettings["ServiceBusConnectionString"].ToString();
        private static string strQueueName = ConfigurationManager.AppSettings["ServiceBusQueue"].ToString();
        private static string strNotificationConnectionString = ConfigurationManager.AppSettings["NotificationConnectionString"].ToString();
        private static string strNotificationHubName = ConfigurationManager.AppSettings["NotificationHubName"].ToString();
        private static string strSendGridKey = ConfigurationManager.AppSettings["SendGridKey"].ToString();
        private static string strSendGridFromMail = ConfigurationManager.AppSettings["SendGridFromMail"].ToString();
        private static List<string> strSendGridMailList = ConfigurationManager.AppSettings["SendGridMailList"].ToString().Split(";".ToCharArray()).ToList();

        public static void LookupNotification()
        {
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

                        // 進行訊息的推送
                        SendNotificationAsync("alert!!" + msg);

                        // 透過SendGrid的email發送
                        SendGridMail("alert!!", msg);

                        // 設定Queue裡的訊息已被讀取
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
                }
            }, options);
        }

        #region // SendNotificationAsync
        /// <summary>
        /// 進行訊息推播的動作
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        private static async Task SendNotificationAsync(string msg)
        {
            await SendWindowsNotificationAsync(msg);
            await SendAndroidNotificationAsync(msg);
        }

        /// <summary>
        /// 傳送Windows Phone的訊息推播
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        private static async Task SendWindowsNotificationAsync(string msg)
        {
            NotificationHubClient hub = NotificationHubClient
                .CreateClientFromConnectionString(strNotificationConnectionString, strNotificationHubName);
            var toast = $"<toast launch=\"launch_arguments\"><visual><binding template=\"ToastText01\"><text id=\"1\">{msg}</text></binding></visual></toast>";
            var results = await hub.SendWindowsNativeNotificationAsync(toast);
        }

        /// <summary>
        /// 傳送Android的訊息推播
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        private static async Task SendAndroidNotificationAsync(string msg)
        {
            NotificationHubClient hub = NotificationHubClient
                .CreateClientFromConnectionString(strNotificationConnectionString, strNotificationHubName);
            Newtonsoft.Json.Linq.JObject o = JsonConvert.DeserializeObject(msg) as Newtonsoft.Json.Linq.JObject;
            var toast = "{data:{message:'{device} alert at {time}'}}".Replace("{device}", (string)o["deviceid"]).Replace("{time}", (string)o["time"]);
            var results = await hub.SendGcmNativeNotificationAsync(toast);
        }
        #endregion

        #region // SendGrid
        /// <summary>
        /// 透過SendGrid寄送信件
        /// </summary>
        /// <param name="strSubject"></param>
        /// <param name="strContent"></param>
        /// <returns></returns>
        private static async Task SendGridMail(string strSubject, string strContent)
        {
            var apiKey = strSendGridKey;
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(strSendGridFromMail),
                Subject = strSubject,
                PlainTextContent = strContent,
                HtmlContent = $"<strong>{strContent}</strong>"
            };
            for (int i = 0; i < strSendGridMailList.Count; i++)
                msg.AddTo(new EmailAddress(strSendGridMailList[i], strSendGridMailList[i]));

            var response = await client.SendEmailAsync(msg);
        }
        #endregion
    }
}
