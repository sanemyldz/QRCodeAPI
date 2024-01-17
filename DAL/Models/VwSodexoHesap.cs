using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSodexoHesap
    {
        public int Id { get; set; }
        public int? BirimId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAd { get; set; } = null!;
        public int BolumId { get; set; }
        public string AdSoyad { get; set; } = null!;
        public string? Tcnumarasi { get; set; }
        public string? SicilNo { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public DateTime? Tarih { get; set; }
        public int CalisilanSure { get; set; }
        public int MesaiSuresi { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int Sure { get; set; }
        public int? FazlaCalisma { get; set; }
        public int? EksikCalisma { get; set; }
        public int Tatil { get; set; }
        public int Haftasonu { get; set; }
        public int SodexoHi { get; set; }
        public int? SodexoHs { get; set; }
    }
}
