using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace IoT_WebAppGateWay.Models
{
    [Table("DeviceData")]
    public class DeviceData
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Column(Order = 1)]
        public string DeviceId { get; set; }

        [Column(Order = 2)]
        public DateTime SendDateTime { get; set; }

        [Column(Order = 3)]
        public decimal Temperature { get; set; }

        [Column(Order = 4)]
        public decimal Humidity { get; set; }

        [Column(Order = 5)]
        public decimal PM25 { get; set; }
    }
}