using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectOdalardakiSiciller
    {
        public int OdaId { get; set; }
        public string? OdaAdi { get; set; }
        public int? SicilId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public int? BolumId { get; set; }
        public int? PozisyonId { get; set; }
        public int? GorevId { get; set; }
        public int? FirmaId { get; set; }
        public string? Sicilno { get; set; }
        public string? PersonelNo { get; set; }
        public int? BirimId { get; set; }
        public string? BolumAdi { get; set; }
        public string? BirimAdi { get; set; }
        public string? GorevAdi { get; set; }
        public string? PozisyonAdi { get; set; }
        public string? FirmaAdi { get; set; }
        public int? PoolId { get; set; }
        public string? TerminalAd { get; set; }
        public DateTime? OlayZamani { get; set; }
    }
}
