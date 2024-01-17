using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TimeZone
    {
        public int Id { get; set; }
        public string TimeZoneName { get; set; } = null!;
        public int TimeZoneId { get; set; }
        public bool? Tatil1 { get; set; }
        public bool? Tatil2 { get; set; }
        public bool? Pazartesi { get; set; }
        public bool? Sali { get; set; }
        public bool? Carsamba { get; set; }
        public bool? Persembe { get; set; }
        public bool? Cuma { get; set; }
        public bool? Cumartesi { get; set; }
        public bool? Pazar { get; set; }
        public DateTime? Baslama { get; set; }
        public DateTime? Bitme { get; set; }
        public int? Index { get; set; }
    }
}
