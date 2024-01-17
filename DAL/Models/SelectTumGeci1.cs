using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SelectTumGeci1
    {
        public DateTime EventTime { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string Name { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
    }
}
