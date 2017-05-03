using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Gpio;
using Sensors.Dht;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;
using RaspberryPi.Services;

namespace RaspberryPi.Objects
{
    class SensorObj : BaseObj
    {
        /// <summary>
        /// 用來接收偵測資訊用的Pin腳編號
        /// </summary>
        public int SensorPinNo { get; set; }
        /// <summary>
        /// 偵測資訊的秒數
        /// </summary>
        public int TelemetrySecound { get; set; }
        /// <summary>
        /// 要送至IoTHub的物件
        /// </summary>
        public IoTObj IoTHub { get; set; }

        // 溫濕度的設定
        private GpioPin pinSensor = null;
        private GpioController objGpio;
        private Dht22 objDht = null;
        private DhtReading reading = new DhtReading();
        private DispatcherTimer tiSensor;
        private string strLastSuccessTime;

        public SensorObj(GpioController objGpioController, int intSensorPinNo, int intTelemetrySecound, TextBlock objStatusTextBlock, Ellipse objStatusEllipse, TextBlock objLastTime, IoTObj objIoTHub)
        {
            // 放入偵測物件必須的四個屬性
            this.SensorPinNo = intSensorPinNo;
            this.TelemetrySecound = intTelemetrySecound;
            this.StatusTextBlock = objStatusTextBlock;
            this.StatusEllipse = objStatusEllipse;
            this.StatusLastTime = objLastTime;
            this.objGpio = objGpioController;

            // 放入IoTObj
            this.IoTHub = objIoTHub;

            // Sensor
            tiSensor = new DispatcherTimer();
            tiSensor.Interval = TimeSpan.FromMilliseconds(this.TelemetrySecound * 1000);
            tiSensor.Tick += tiSensor_Tick;

            // 初始化GPIO pin
            InitGPIO();
        }

        /// <summary>
        /// 啟動偵測裝置
        /// </summary>
        public async void Start()
        {
            await this.GetSensorData();
        }

        /// <summary>
        /// 停止偵測裝置
        /// </summary>
        public void Stop()
        {
            tiSensor.Stop();
            base.SetError("偵測裝置已從遠端停止");
        }

        private async void InitGPIO()
        {
            pinSensor = null;

            // 初始化Sensor
            if (this.objGpio != null)
            {
                pinSensor = this.objGpio.OpenPin(this.SensorPinNo, GpioSharingMode.Exclusive);
            }

            // 如果有抓到Sensor的Pin腳，就開始收集資料
            if (pinSensor != null)
            {
                objDht = new Dht22(pinSensor, GpioPinDriveMode.Input);
                await GetSensorData();
            }
            else
            {
                base.SetError("GPIO/PIN 無法初始化");
            }
        }

        private async void tiSensor_Tick(object sender, object e)
        {
            await GetSensorData();
        }

        private async Task GetSensorData()
        {
            tiSensor.Stop();
            try
            {
                reading = await objDht.GetReadingAsync().AsTask();
                if (reading.IsValid)
                {
                    strLastSuccessTime = DateTime.UtcNow.ToString();
                    string strOperationText = "{0:0.0} °C, {1:0.0} %";
                    // 取得溫濕度的資料
                    var temperature = Convert.ToSingle(reading.Temperature);
                    var humidity = Convert.ToSingle(reading.Humidity);
                    strOperationText = string.Format(strOperationText, temperature, humidity);
                    base.SetOperation(strOperationText, DateTime.UtcNow);

                    // 送至IoT Hub
                    await this.IoTHub.Send(reading.Temperature, reading.Humidity);
                }
                else
                {
                    base.SetError("偵測裝置無法讀取");
                    // 讀不到資訊，等待一秒後再讀一次
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    await this.GetSensorData();
                }
            }
            catch (Exception ex)
            {
                base.SetError(ex.Message);
            }
            finally
            {
                tiSensor.Start();
            }
        }
    }
}
