using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwArgeAraGecisStg
    {
        public int SicilId { get; set; }
        public string? Sicil { get; set; }
        public DateTime Tarih { get; set; }
        public string? Gun { get; set; }
        public string AdSoyad { get; set; } = null!;
        public string Departman { get; set; } = null!;
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public string Tcno { get; set; } = null!;
        public int BirimId { get; set; }
        public string BirimAd { get; set; } = null!;
        public int FirmaId { get; set; }
        public string FirmaAd { get; set; } = null!;
        public int BolumId { get; set; }
        public string BolumAd { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAd { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAd { get; set; } = null!;
        public int? EksikCalisma { get; set; }
        public int? FazlaCalisma { get; set; }
        public int? BalansCalisma { get; set; }
    }
}
