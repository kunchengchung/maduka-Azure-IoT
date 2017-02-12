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

namespace IoT_Controller
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 回送訊息的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnSend_Click(object sender, EventArgs e)
        {
            string strConn = txtConnectionString.Text;
            string strDeviceId = txtDeviceId.Text;
            string strMessage = txtMessage.Text;

            ServiceClient serviceClient = ServiceClient.CreateFromConnectionString(strConn);
            var serviceMessage = new Microsoft.Azure.Devices.Message(Encoding.ASCII.GetBytes(strMessage));

            serviceMessage.Ack = DeliveryAcknowledgement.Full;
            serviceMessage.MessageId = Guid.NewGuid().ToString();
            await serviceClient.SendAsync(strDeviceId, serviceMessage);

            if (txtCallMethod.Text != "")
            {
                TimeSpan objTimeSpan = new TimeSpan(0, 0, 0, int.Parse(txtTimeout.Text));
                await serviceClient.InvokeDeviceMethodAsync(txtDeviceId.Text, new CloudToDeviceMethod(txtCallMethod.Text, objTimeSpan));
            }

            await serviceClient.CloseAsync();
        }
    }
}
