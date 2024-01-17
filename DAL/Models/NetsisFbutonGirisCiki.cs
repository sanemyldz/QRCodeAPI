using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class NetsisFbutonGirisCiki
    {
        public DateTime IzinTarih { get; set; }
        public string? SicilNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string FirmaAd { get; set; } = null!;
        public string BolumAd { get; set; } = null!;
        public string PozisyonAd { get; set; } = null!;
        public string GorevAd { get; set; } = null!;
        public string Aciklama { get; set; } = null!;
        public DateTime? IzinBaslangic { get; set; }
        public DateTime? IzinBitis { get; set; }
        public bool Ucretli { get; set; }
        public bool Saatlikizin { get; set; }
        public int IzinlerId { get; set; }
    }
}
