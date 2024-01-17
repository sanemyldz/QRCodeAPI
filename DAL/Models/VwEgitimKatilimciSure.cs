using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwEgitimKatilimciSure
    {
        public int Id { get; set; }
        public string EgitimAdi { get; set; } = null!;
        public DateTime? BaslangicZamani { get; set; }
        public DateTime? BitisZamani { get; set; }
        public bool? PlansizEgitim { get; set; }
        public string? SicilNo { get; set; }
        public string SicilAd { get; set; } = null!;
        public string SicilSoyad { get; set; } = null!;
        public string? PersonelNo { get; set; }
        public int SicilId { get; set; }
        public int? BirimId { get; set; }
        public int? FirmaId { get; set; }
        public int? BolumId { get; set; }
        public int? GorevId { get; set; }
        public int? PozisyonId { get; set; }
        public string? BirimAdi { get; set; }
        public string? FirmaAdi { get; set; }
        public string? BolumAdi { get; set; }
        public string? GorevAdi { get; set; }
        public string? PozisyonAdi { get; set; }
    }
}
