using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoT_Simulator
{
    public class MessageModel
    {
        public string DeviceId { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double PM25 { get; set; }
        public DateTime SendDateTime { get; set; }
    }
}