using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwIceridekiler
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? PersonelNo { get; set; }
        public DateTime? GirisTarih { get; set; }
        public DateTime? CikisTarih { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string LokasyonAdi { get; set; } = null!;
        public int LokasyonId { get; set; }
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public string? TerminalAdi { get; set; }
        public DateTime? GecisZamani { get; set; }
        public int? Ioid { get; set; }
        public string? YonAd { get; set; }
    }
}
