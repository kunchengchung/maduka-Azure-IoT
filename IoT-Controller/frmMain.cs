using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Devices;
using System.Configuration;

namespace IoT_Controller
{
    public partial class frmMain : Form
    {

        string strConn = ConfigurationManager.ConnectionStrings["IoTHub"].ToString();
        ServiceClient serviceClient;

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 頁面讀取的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            serviceClient = ServiceClient.CreateFromConnectionString(strConn);
        }

        /// <summary>
        /// 回送訊息的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnSend_Click(object sender, EventArgs e)
        {
            string strDeviceId = txtDeviceId.Text;
            string strMessage = txtMessage.Text;

            if (!string.IsNullOrEmpty(strMessage))
            {
                var serviceMessage = new Microsoft.Azure.Devices.Message(Encoding.ASCII.GetBytes(strMessage));
                serviceMessage.Ack = DeliveryAcknowledgement.Full;
                serviceMessage.MessageId = Guid.NewGuid().ToString();
                await serviceClient.SendAsync(strDeviceId, serviceMessage);
            }
            else
                MessageBox.Show("請輸入要傳送的文字訊息");
        }

        /// <summary>
        /// 呼叫Device端事件方法的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnCallMethod_Click(object sender, EventArgs e)
        {
            string strDeviceId = txtDeviceId.Text;

            if (txtCallMethod.Text != "")
            {
                // 指定TimeOut的秒數
                TimeSpan objTimeSpan = new TimeSpan(0, 0, 0, int.Parse(txtTimeout.Text));
                // 建立呼叫用的DeviceMethod
                CloudToDeviceMethod objMethod = new CloudToDeviceMethod(txtCallMethod.Text, objTimeSpan);
                // 放入要下傳的Json字串
                objMethod.SetPayloadJson(txtPayLoad.Text);
                // 執行呼叫的動作
                CloudToDeviceMethodResult result =  await serviceClient.InvokeDeviceMethodAsync(txtDeviceId.Text, objMethod);
                // 將結果放入到控制項中
                txtResultStatus.Text = result.Status.ToString();
                txtCallMethodResult.Text = result.GetPayloadAsJson();
            }
            else
                MessageBox.Show("請輸入要呼叫的事件方法名稱");
        }

        /// <summary>
        /// 關閉表單的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            await serviceClient.CloseAsync();
        }
    }
}
