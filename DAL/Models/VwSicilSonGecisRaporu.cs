using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSicilSonGecisRaporu
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string PersonelNo { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public DateTime CikisTarih { get; set; }
        public bool Deleted { get; set; }
        public int FirmaId { get; set; }
        public string FirmaKodu { get; set; } = null!;
        public string FirmaAd { get; set; } = null!;
        public int BolumId { get; set; }
        public string BolumAd { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAd { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAd { get; set; } = null!;
        public int BirimId { get; set; }
        public string BirimAd { get; set; } = null!;
        public DateTime SonGecis { get; set; }
        public string TerminalAdi { get; set; } = null!;
    }
}
