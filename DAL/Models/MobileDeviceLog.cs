using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MobileDeviceLog
    {
        public int Id { get; set; }
        public string? CardNumber { get; set; }
        public string? DeviceId { get; set; }
        public string? Direction { get; set; }
        public string? EventTime { get; set; }
        public string? AdSoyad { get; set; }
        public string? PhotoBase64 { get; set; }
        public bool? Aktarildi { get; set; }
    }
}
