using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwPdksilkGirisSonCikisaGore
    {
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? Tcno { get; set; }
        public string? SicilNo { get; set; }
        public DateTime Mesaitarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int FazlaMesai { get; set; }
        public int ErkenMesai { get; set; }
        public string? IzinAciklama { get; set; }
        public int CalismaSuresi { get; set; }
        public int NormalCalisma { get; set; }
        public int YemekSuresi { get; set; }
        public int BirimId { get; set; }
        public string? BirimAdi { get; set; }
        public int BolumId { get; set; }
        public string BolumAd { get; set; } = null!;
        public int GorevId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string GorevAdi { get; set; } = null!;
    }
}
