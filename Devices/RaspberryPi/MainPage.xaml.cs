using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Gpio;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白頁項目範本已記錄在 https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x404

namespace RaspberryPi
{
    /// <summary>
    /// 可以在本身使用或巡覽至框架內的空白頁面。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // IoT Hub的設定
        string strDeviceId = "[裝置代碼]";
        string strDeviceKey = "[存取金鑰]";
        string strIoTHubUrl = "[IoT Hub Url]";
        int intSensorPin = 17; // 連接DTH22 的 GPIO Pin編號
        static Objects.IoTObj objIoT = null;
        static Objects.SensorObj objSensor = null;
        GpioController objGpioController = GpioController.GetDefault();

        public MainPage()
        {
            this.InitializeComponent();

            // 初始化IoT
            objIoT = new Objects.IoTObj(strIoTHubUrl, strDeviceId, strDeviceKey)
            {
                StatusEllipse = IoTHubLED,
                StatusTextBlock = txtIoTStatus,
                StatusLastTime = txtIoTTime,
                FromIoTMessage = txtFromIoTMessage,
            };
            objIoT.Received += ObjIoT_Received;
            objIoT.Open();

            // 啟動偵測功能
            objSensor = new Objects.SensorObj(objGpioController, intSensorPin, 59, txtSensorStatus, SensorLED, txtSensorTime, objIoT);
        }

        /// <summary>
        /// 如果訊息取得是下指令的話，就在這裡進行指令的處理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ObjIoT_Received(object sender, EventArgs e) => CommandAnalytics(sender.ToString());

        /// <summary>
        /// 從伺服器傳入的命令解析動作
        /// </summary>
        /// <param name="strCommand"></param>
        /// <returns></returns>
        private void CommandAnalytics(string strCommand) => txtFromIoTMessage.Text = strCommand;
    }
}
