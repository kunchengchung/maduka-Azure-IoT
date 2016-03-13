using Microsoft.Azure.Devices;
using Microsoft.Azure.Devices.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IoT_Simulator
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// 定義IoT Hub的連線字串
        /// </summary>
        string strIoTHubConnectionString = "[請在這裡置換IoT Hub的Connection String]";
        /// <summary>
        /// 定義IoT Hub的Url
        /// </summary>
        string strIoTHubUrl = "[請在這裡置換IoT Hub的Url]";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 註冊裝置代碼，並取得裝置的Key值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnRegistry_Click(object sender, EventArgs e)
        {
            string strDeviceId = txtDeviceId.Text;

            Device objDevice = null;
            RegistryManager registryManager = RegistryManager.CreateFromConnectionString(strIoTHubConnectionString);

            // 先從Azure IoT Hub上取得裝置是不是已經存在
            objDevice = await registryManager.GetDeviceAsync(strDeviceId);

            // 如果裝置不存在Azure IoT Hub上的話，就註冊進IoT Hub
            if (objDevice == null)
            {
                objDevice = await registryManager.AddDeviceAsync(new Device(strDeviceId));
                if (objDevice != null)
                    MessageBox.Show("該裝置已完成註冊");
            }

            // 取得裝置註冊之後的Device Key
            if (objDevice != null)
            {
                txtDeviceKey.Text = objDevice.Authentication.SymmetricKey.PrimaryKey;

                // 放入傳送訊息用的內容
                string strMessage = IoT_Simulator.Properties.Resources.IoTMessage;
                strMessage = strMessage.Replace("{0}", txtDeviceId.Text);
                strMessage = strMessage.Replace("{1}", DateTime.UtcNow.ToString("yyyy/MM/dd"));
                txtMessage.Text = strMessage;
            }
            else
            {
                MessageBox.Show("該裝置無法於Azure IoT Hub中註冊");
            }
        }

        /// <summary>
        /// 將裝置從Azure IoT Hub上解除註冊
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnUnregistry_Click(object sender, EventArgs e)
        {
            string strDeviceId = txtDeviceId.Text;
            // 先從Azure IoT Hub上取得裝置是不是已經存在
            Device objDevice = null;
            RegistryManager registryManager = RegistryManager.CreateFromConnectionString(strIoTHubConnectionString);
            objDevice = await registryManager.GetDeviceAsync(strDeviceId);

            // 如果裝置已經存在，就解除註冊
            if (objDevice != null)
            {
                await registryManager.RemoveDeviceAsync(objDevice);
                txtDeviceKey.Text = "";
                MessageBox.Show("該裝置已解除註冊");
            }
            else
            {
                MessageBox.Show("該裝置不存在於Azure IoT Hub之中");
            }
        }

        /// <summary>
        /// 傳送訊息至Azure IoT Hub之中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnSend_Click(object sender, EventArgs e)
        {
            string strJsonMessage = txtMessage.Text;
            string strDeviceId = txtDeviceId.Text;
            string strDeviceKey = txtDeviceKey.Text;

            DeviceClient deviceClient = DeviceClient.Create(strIoTHubUrl,
                new DeviceAuthenticationWithRegistrySymmetricKey(strDeviceId, strDeviceKey));

            await deviceClient.SendEventAsync(new Microsoft.Azure.Devices.Client.Message(Encoding.UTF8.GetBytes(strJsonMessage)));

            MessageBox.Show("訊息已傳送成功");
        }
    }
}
