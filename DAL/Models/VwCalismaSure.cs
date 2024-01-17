using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwCalismaSure
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int NormalSure { get; set; }
        public string? Tcno { get; set; }
        public int BirimId { get; set; }
        public string? BirimAdi { get; set; }
        public string FirmaAd { get; set; } = null!;
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int GorevId { get; set; }
        public int PozisyonId { get; set; }
        public string BolumAd { get; set; } = null!;
        public string GorevAd { get; set; } = null!;
        public string PozisyonAd { get; set; } = null!;
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
        public int IzinTip { get; set; }
    }
}
