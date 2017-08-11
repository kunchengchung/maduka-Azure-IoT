namespace IoT_WebAppGateWay.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class IoTModel : DbContext
    {
        public IoTModel()
            : base("name=IoTModel")
        {
        }

        public virtual DbSet<DeviceFile> DeviceFile { get; set; }
        public virtual DbSet<DeviceData> DeviceData { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
