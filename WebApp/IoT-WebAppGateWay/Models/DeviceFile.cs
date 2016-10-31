namespace IoT_WebAppGateWay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeviceFile")]
    public partial class DeviceFile
    {
        [Key]
        [Column(Order = 0)]
        public string DeviceId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string DeviceKey { get; set; }
    }
}
