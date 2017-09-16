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
using System.Configuration;

namespace IoT_Simulator
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// 定義IoT Hub的連線字串
        /// </summary>
        string strIoTHubConnectionString = ConfigurationManager.ConnectionStrings["IoTHub"].ToString();
        /// <summary>
        /// 定義IoT Hub的Url
        /// </summary>
        string strIoTHubUrl = ConfigurationManager.AppSettings["IoTHubUrl"].ToString();
        /// <summary>
        /// 定義裝置物件
        /// </summary>
        DeviceClient deviceClient = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private async void frmMain_Load(object sender, EventArgs e)
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

                // 指定裝置物件的資訊，並建立連線狀態
                deviceClient = DeviceClient.CreateFromConnectionString($"HostName={strIoTHubUrl};DeviceId={txtDeviceId.Text};SharedAccessKey={txtDeviceKey.Text}", Microsoft.Azure.Devices.Client.TransportType.Amqp);

                // 放入傳送訊息用的內容
                MessageModel objMsg = new MessageModel()
                {
                    DeviceId = txtDeviceId.Text,
                    Humidity = new Random().Next(30, 60),
                    PM25 = new Random().Next(0, 30),
                    SendDateTime = DateTime.Now,
                    Temperature = new Random().Next(25, 35),
                };
                txtMessage.Text = JsonConvert.SerializeObject(objMsg);
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
                deviceClient = null;
                MessageBox.Show("該裝置已解除註冊");
            }
            else
            {
                MessageBox.Show("該裝置不存在於Azure IoT Hub之中");
            }
        }

        /// <summary>
        /// 傳送檔案到IoT Hub中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnUploadFile_Click(object sender, EventArgs e)
        {
            string strDeviceId = txtDeviceId.Text;
            string strDeviceKey = txtDeviceKey.Text;

            // 如果裝置未註冊，就手動進行建立連線的動作
            if (deviceClient == null)
                deviceClient = DeviceClient.CreateFromConnectionString($"HostName={strIoTHubUrl};DeviceId={txtDeviceId.Text};SharedAccessKey={txtDeviceKey.Text}", Microsoft.Azure.Devices.Client.TransportType.Amqp);

            using (var fileStream = new FileStream(txtFileName.Text, FileMode.Open, FileAccess.Read))
            {
                await deviceClient.UploadToBlobAsync(txtBlobName.Text, fileStream);
                MessageBox.Show("檔案已傳送成功");
            }
        }

        /// <summary>
        /// 檔案打開的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        /// <summary>
        /// 選擇檔案的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtFileName.Text = openFileDialog1.FileName;
        }

        /// <summary>
        /// 發送單一訊習
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (rbnIoTHub.Checked)
                this.SendToIoTHub(true);
            else
                this.SendToWebAPI(true);
        }

        /// <summary>
        /// 使用Timer作發送的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendAndStop_Click(object sender, EventArgs e)
        {
            btnSendAndStop.Text = (tiSend.Enabled) ? "Send with timer" : "Stop";
            tiSend.Enabled = !tiSend.Enabled;
        }

        /// <summary>
        /// Timer被啟動的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tiSend_Tick(object sender, EventArgs e)
        {
            MessageModel objMsg = new MessageModel()
            {
                DeviceId = txtDeviceId.Text,
                Humidity = new Random().Next(30, 60),
                PM25 = new Random().Next(0, 30),
                SendDateTime = DateTime.Now,
                Temperature = new Random().Next(25, 35),
            };
            txtMessage.Text = JsonConvert.SerializeObject(objMsg);

            if (rbnIoTHub.Checked)
                this.SendToIoTHub(false);
            else
                this.SendToWebAPI(false);
        }

        /// <summary>
        /// 傳送訊息至Azure IoT Hub之中
        /// </summary>
        private async void SendToIoTHub(bool blShowMessage)
        {
            string strJsonMessage = txtMessage.Text;
            string strDeviceId = txtDeviceId.Text;
            string strDeviceKey = txtDeviceKey.Text;

            if (deviceClient == null)
                deviceClient = DeviceClient.CreateFromConnectionString($"HostName={strIoTHubUrl};DeviceId={txtDeviceId.Text};SharedAccessKey={txtDeviceKey.Text}", Microsoft.Azure.Devices.Client.TransportType.Amqp);

            try
            {
                await deviceClient.SendEventAsync(new Microsoft.Azure.Devices.Client.Message(Encoding.UTF8.GetBytes(strJsonMessage)));

                if (blShowMessage)
                    MessageBox.Show("訊息已傳送成功");
                else
                    lblSendMessage.Text = "訊息已傳送成功";
            }
            catch   (Exception e)
            {
                if (blShowMessage)
                    MessageBox.Show("發送失敗," + e.Message);
                else
                    lblSendMessage.Text = "發送失敗," + e.Message;
            }
        }

        /// <summary>
        /// 將訊息送出至WebAPI的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendToWebAPI(bool blShowMessage)
        {
            // 因為只要送到WebAPI，所以只要訊息跟裝置代碼就夠了
            MessageModel objMsg = JsonConvert.DeserializeObject<MessageModel>(txtMessage.Text);

            // 放在網路上的WebApp的Url
            string strUrl = ConfigurationManager.AppSettings["IoTGateway"].ToString();

            // 送出至WebAPI
            HttpStatusCode code = HttpStatusCode.OK;
            string strResponse = CallAPI(strUrl, "POST", JsonConvert.SerializeObject(objMsg), out code);

            if (code == HttpStatusCode.OK)
            {
                if (blShowMessage)
                    MessageBox.Show("發送完成");
                else
                    lblSendMessage.Text = "訊息已傳送成功";
            }
            else
            {
                if (blShowMessage)
                    MessageBox.Show("發送失敗," + strResponse);
                else
                    lblSendMessage.Text = "發送失敗," + strResponse;
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
            if (deviceClient == null)
                deviceClient = DeviceClient.CreateFromConnectionString($"HostName={strIoTHubUrl};DeviceId={txtDeviceId.Text};SharedAccessKey={txtDeviceKey.Text}", Microsoft.Azure.Devices.Client.TransportType.Amqp);

            Microsoft.Azure.Devices.Client.Message receivedMessage;
            string messageData;
            while (true)
            {
                receivedMessage = await deviceClient.ReceiveAsync(TimeSpan.FromSeconds(1));

                if (receivedMessage != null)
                {
                    messageData = Encoding.UTF8.GetString(receivedMessage.GetBytes());

                    // 取得回傳的Key與Value
                    foreach (var item in receivedMessage.Properties)
                    {
                        var strKey = item.Key;
                        var strValue = item.Value;
                    }

                    // 標示訊息已被讀取
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

        /// <summary>
        /// 註冊Call Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnRegistryMethod_Click(object sender, EventArgs e)
        {
            if (deviceClient == null)
                deviceClient = DeviceClient.CreateFromConnectionString($"HostName={strIoTHubUrl};DeviceId={txtDeviceId.Text};SharedAccessKey={txtDeviceKey.Text}", Microsoft.Azure.Devices.Client.TransportType.Amqp);

            // 註冊回傳事件的動作
            await deviceClient.SetMethodHandlerAsync(txtMethodName.Text, OnCallMethod, null);

            // 放入被IoT呼叫後會回傳的訊息內容
            CallMethodModel objModel = new CallMethodModel()
            {
                DeviceId = txtDeviceId.Text,
                OperationMinutes = 135,
                Status = "Online",
            };
            txtCallMethodReturnValue.Text = JsonConvert.SerializeObject(objModel);
        }

        /// <summary>
        /// 當IoT Call Method時，回傳的動作
        /// </summary>
        /// <param name="request"></param>
        /// <param name="userContext"></param>
        /// <returns></returns>
        private async Task<MethodResponse> OnCallMethod(MethodRequest request, object userContext)
        {           
            // 取得從IoT Hub上傳入的參數
            string strInput = request.DataAsJson;

            // 取得設定要直接回傳的值
            string strReturnValue = txtCallMethodReturnValue.Text;

            // 進行回傳動作
            MessageBox.Show(strInput);

            return new MethodResponse(Encoding.UTF8.GetBytes(strReturnValue), 200);
        }
    }
}
