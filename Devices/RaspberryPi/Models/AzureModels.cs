using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaspberryPi.Models
{
    public class AzureModels
    {
        public class SensorModel
        {
            public string DeviceId { get; set; }
            public double Temperature { get; set; }
            public double Humidity { get; set; }
            public double PM25 { get; set; }
            public DateTime SendDateTime { get; set; }
        }
    }
}
