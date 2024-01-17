using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Vw0200101
    {
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? KimlikNo { get; set; }
        public int? BirimId { get; set; }
        public int? BolumId { get; set; }
        public int? FirmaIdd { get; set; }
        public int? LokasyonId { get; set; }
        public int? PozisyonId { get; set; }
        public string? BirimAdi { get; set; }
        public string BolumAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string LokasyonAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string? Okod1 { get; set; }
        public string? Okod2 { get; set; }
        public DateTime Zaman { get; set; }
        public int TaseronFirmaId { get; set; }
    }
}
