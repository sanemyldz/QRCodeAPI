using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class NetsisOglenGirisCiki
    {
        public DateTime? MesaiTarih { get; set; }
        public string? SicilNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string FirmaAd { get; set; } = null!;
        public string BolumAd { get; set; } = null!;
        public string PozisyonAd { get; set; } = null!;
        public string GorevAd { get; set; } = null!;
        public DateTime? OglenCikis { get; set; }
        public DateTime? OglenGiris { get; set; }
        public int TasnislemeId { get; set; }
    }
}
