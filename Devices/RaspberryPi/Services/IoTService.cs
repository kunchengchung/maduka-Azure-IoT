using Microsoft.Azure.Devices.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RaspberryPi.Services
{
    public class IoTService
    {
        public string IoTUrl { get; set; }
        public string DeviceId { get; set; }
        public string DeviceKey { get; set; }
        public TransportType TransType { get; set; }
        public string ErrorMessage { get; set; }
        DeviceClient deviceClient = null;

        /// <summary>  
        /// 引發取得訊息的事件。  
        /// </summary>  
        public event EventHandler Received;

        /// <summary>
        /// 開啟IoT Hub的連線
        /// </summary>
        public void Open()
        {
            deviceClient = DeviceClient.CreateFromConnectionString($"HostName={IoTUrl};DeviceId={DeviceId};SharedAccessKey={DeviceKey}", TransType);
        }

        /// <summary>
        /// 傳送IoT訊息至Azure IoT hub的動作
        /// </summary>
        /// <param name="strMessage">傳送的JSON格式訊息</param>
        /// <returns></returns>
        public async Task<bool> Send(Models.AzureModels.SensorModel objSensor)
        {
            /* Set Raspberry Pi DateTime whti PwerShell Command
                "net start WinRM"
                "Set-Item WSMan:\localhost\Client\TrustedHosts -Value <machine-name or IP Address>"
                "Enter-PSSession -ComputerName <IP Address> -Credential localhost\Administrator"
                "Set-Date "mm / dd / yy hh: mm: ss AM/ PM""
            */

            bool blflag = false;
            string strJson = JsonConvert.SerializeObject(objSensor);

            try
            {
                await deviceClient.SendEventAsync(new Message(Encoding.UTF8.GetBytes(strJson)));
                blflag = true;
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }

            return blflag;
        }

        public async Task Receive()
        {
            Message receivedMessage;
            string messageData;
            while (true)
            {
                receivedMessage = await deviceClient.ReceiveAsync(TimeSpan.FromSeconds(1));

                if (receivedMessage != null)
                {
                    messageData = Encoding.UTF8.GetString(receivedMessage.GetBytes());
                    await deviceClient.CompleteAsync(receivedMessage);
                    this.RaiseReceivedEvent(messageData.ToLower());
                }
            }
        }

        /// <summary>  
        /// 引發換頁事件。  
        /// </summary>  
        public void RaiseReceivedEvent(string strMessage)
        {
            if (Received != null)
                Received(strMessage, EventArgs.Empty);
        }
    }
}