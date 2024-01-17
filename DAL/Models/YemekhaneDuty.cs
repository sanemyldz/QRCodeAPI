using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class YemekhaneDuty
    {
        public int Id { get; set; }
        public string? TargetDevice { get; set; }
        public string? Process { get; set; }
        public string? UserId { get; set; }
        public string? Owner { get; set; }
        public DateTime? RecordDate { get; set; }
        public DateTime? ProcessDate { get; set; }
        public string? TimeZoneId { get; set; }
        public string? DeviceMessage { get; set; }
    }
}
