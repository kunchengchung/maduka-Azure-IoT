using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IoT_WebAppGateWay
{
    public partial class Default : System.Web.UI.Page
    {
        protected string strTempData;
        protected string strHumiData;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
                this.BindData();
            }
        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            this.BindData();
        }

        private void BindData()
        {
            DateTime dtStart = DateTime.Parse(txtDate.Text);
            DateTime dtEnd = dtStart.AddDays(1);

            List<Models.DeviceData> objData = new Models.IoTModel().DeviceData
                  .Where(x => x.SendDateTime >= dtStart && x.SendDateTime <= dtEnd)
                  .ToList();

            int intCount = objData.Count;
            for (int i = intCount - 1; i >= 0; i--)
            {
                decimal dlTemp = objData[i].Temperature;
                decimal dlHumi = objData[i].Humidity;
                DateTime dt = objData[i].SendDateTime;

                if (dlTemp > 0 && dlTemp < 35)
                {
                    string strDateString = "new Date(" + dt.Year + "," + dt.Month + "," + dt.Day + "," + dt.Hour + "," + dt.Minute + "," + dt.Second + ")";
                    strTempData += "{x:" + strDateString + ", y:" + dlTemp.ToString() + "}";
                    strHumiData += "{x:" + strDateString + ", y:" + dlHumi.ToString() + "}";

                    if (i > 0)
                    {
                        strTempData += ",";
                        strHumiData += ",";
                    }
                }
            }
        }
    }
}