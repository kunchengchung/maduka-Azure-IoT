using Microsoft.Azure.Devices.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace IoT_WebAppGateWay.Controllers
{
    public class MessagesController : ApiController
    {
        static string iotHubUri = "[IoT Hub的Url]";

        /// <summary>
        /// 發送訊息至IoT Hub
        /// </summary>
        /// <param name="value">發送物件</param>
        /// <returns>true:發送成功  false:發送失敗</returns>
        public async Task<HttpResponseMessage> Post([FromBody]Models.Message value)
        {
            HttpStatusCode code = HttpStatusCode.OK;
            string strContent = "true";

            try
            {
                // 透過EF找出資料庫中該裝置的Key值
                Models.DeviceFile objDevice = new Models.IoTModel().DeviceFile.FirstOrDefault(x => x.DeviceId == value.DeviceId);

                if (objDevice != null)
                {
                    string strDeviceKey = objDevice.DeviceKey;

                    // 傳送訊息進入IoT Hub
                    DeviceClient deviceClient = null;
                    deviceClient = DeviceClient.CreateFromConnectionString
                    (
                        $"HostName={iotHubUri};DeviceId={objDevice.DeviceId};SharedAccessKey={objDevice.DeviceKey}",
                        Microsoft.Azure.Devices.Client.TransportType.Amqp
                    );

                    await deviceClient.SendEventAsync(new Microsoft.Azure.Devices.Client.Message(Encoding.UTF8.GetBytes(value.MessageContent)));
                }
                else
                {
                    code = HttpStatusCode.NotFound;
                    strContent = "找不到該裝置，該裝置並無登錄於資料庫中";
                }

            }
            catch (Exception e)
            {
                code = HttpStatusCode.BadRequest;
                strContent = e.Message;
            }

            return Request.CreateResponse(code, strContent);
        }
    }
}
