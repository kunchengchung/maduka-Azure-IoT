using Microsoft.Azure.Devices;
using Microsoft.Azure.Devices.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading.Tasks;

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

        /// <summary>
        /// 將訊息送出至WebAPI的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendToWebAPI_Click(object sender, EventArgs e)
        {
            // 因為只要送到WebAPI，所以只要訊息跟裝置代碼就夠了
            MessageModel objMsg = new MessageModel()
            {
                DeviceId = txtDeviceId.Text,
                MessageContent = txtMessage.Text,
            };

            // 放在網路上的WebApp的Url
            string strUrl = "[WebAPI的Url]";

            // 送出至WebAPI
            HttpStatusCode code = HttpStatusCode.OK;
            string strResponse = CallAPI(strUrl, "POST", JsonConvert.SerializeObject(objMsg) , out code);

            if (code == HttpStatusCode.OK)
            {
                MessageBox.Show("發送完成");
            }
            else
            {
                MessageBox.Show("發送失敗," + strResponse);
            }
        }

        /// <summary>
        /// 按下回收訊息的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceiveMessage_Click(object sender, EventArgs e)
        {
            this.Receive();
        }

        /// <summary>
        /// 執行回收訊息的動作
        /// </summary>
        /// <returns></returns>
        public async Task Receive()
        {
            DeviceClient deviceClient = DeviceClient.CreateFromConnectionString($"HostName={strIoTHubUrl};DeviceId={txtDeviceId.Text};SharedAccessKey={txtDeviceKey.Text}", Microsoft.Azure.Devices.Client.TransportType.Amqp);
            Microsoft.Azure.Devices.Client.Message receivedMessage;
            string messageData;
            while (true)
            {
                receivedMessage = await deviceClient.ReceiveAsync(TimeSpan.FromSeconds(1));

                if (receivedMessage != null)
                {
                    messageData = Encoding.UTF8.GetString(receivedMessage.GetBytes());
                    await deviceClient.CompleteAsync(receivedMessage);
                    MessageBox.Show(messageData);
                }
            }
        }

        protected string CallAPI(string strUrl, string strHttpMethod, string strPostContent, out HttpStatusCode code)
        {
            HttpWebRequest request = HttpWebRequest.Create(strUrl) as HttpWebRequest;
            request.Method = strHttpMethod;
            code = HttpStatusCode.OK;

            if (strPostContent != "" && strPostContent != string.Empty)
            {
                request.KeepAlive = true;
                request.ContentType = "application/json";

                byte[] bs = Encoding.ASCII.GetBytes(strPostContent);
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(bs, 0, bs.Length);
            }

            string strReturn = "";
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var respStream = response.GetResponseStream();
                strReturn = new StreamReader(respStream).ReadToEnd();
            }
            catch (Exception e)
            {
                strReturn = e.Message;
                code = HttpStatusCode.NotFound;
            }

            return strReturn;
        }
    }
}
