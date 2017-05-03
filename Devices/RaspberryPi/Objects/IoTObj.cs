using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaspberryPi.Services;
using Microsoft.Azure.Devices.Client;
using Windows.UI.Xaml.Controls;

namespace RaspberryPi.Objects
{
    class IoTObj : BaseObj
    {
        public string IoTUrl { get; set; }
        public string DeviceId { get; set; }
        public string DeviceKey { get; set; }

        public TextBlock FromIoTMessage { get; set; }

        IoTService objIoT;

        /// <summary>  
        /// 引發取得訊息的事件。  
        /// </summary>  
        public event EventHandler Received;

        /// <summary>
        /// 初始化IoTObj的動作
        /// </summary>
        /// <param name="strIoTUrl"></param>
        /// <param name="strDeviceId"></param>
        /// <param name="strDeviceKey"></param>
        public IoTObj(string strIoTUrl, string strDeviceId, string strDeviceKey)
        {
            this.IoTUrl = strIoTUrl;
            this.DeviceId = strDeviceId;
            this.DeviceKey = strDeviceKey;

            objIoT = new IoTService()
            {
                IoTUrl = this.IoTUrl,
                DeviceId = this.DeviceId,
                DeviceKey = this.DeviceKey,
                TransType = Microsoft.Azure.Devices.Client.TransportType.Amqp,
            };

            objIoT.Received += ObjIoT_Received;
        }

        private void ObjIoT_Received(object sender, EventArgs e)
        {
            if (FromIoTMessage != null)
            {
                string strMessage = sender.ToString();
                FromIoTMessage.Text = strMessage;
                this.RaiseReceivedEvent(strMessage);
            }
        }

        /// <summary>
        /// 開啟IoT的連線
        /// </summary>
        public async void Open()
        {
            try
            {
                // 開啟IoT的連線
                objIoT.Open();
                await objIoT.Receive();
                base.SetOperation(this.IoTUrl, DateTime.UtcNow);
            }
            catch (Exception ex)
            {
                base.SetError(ex.Message);
            }
        }

        /// <summary>
        /// 送出IoT資訊的動作
        /// </summary>
        /// <param name="objData"></param>
        public async Task Send(double dlTemperature, double diHumidity)
        {
            try
            {
                // 送至IoT Hub
                await objIoT.Send(new Models.AzureModels.SensorModel()
                {
                    DeviceId = this.DeviceId,
                    Temperature = dlTemperature,
                    Humidity = diHumidity,
                    PM25 = 0,
                    SendDateTime = DateTime.Now,
                });
                base.SetOperation(this.IoTUrl, DateTime.UtcNow);
            }
            catch (Exception ex)
            {
                base.SetError(ex.Message);
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
