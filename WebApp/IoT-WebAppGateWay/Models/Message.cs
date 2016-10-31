using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoT_WebAppGateWay.Models
{
    public class Message
    {
        public string DeviceId { get; set; }
        public string MessageContent { get; set; }
    }
}