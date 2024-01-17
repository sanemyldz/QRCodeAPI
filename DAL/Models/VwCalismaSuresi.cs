using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwCalismaSuresi
    {
        public DateTime MesaiTarih { get; set; }
        public string? SicilNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int FirmaId { get; set; }
        public int SicilId { get; set; }
        public string FirmaAd { get; set; } = null!;
        public int BolumId { get; set; }
        public string BolumAd { get; set; } = null!;
        public int BirimId { get; set; }
        public string? BirimAd { get; set; }
        public DateTime MesaiSuresi { get; set; }
        public string? ToplamCalisilanSure { get; set; }
        public int MesaiSuresiDk { get; set; }
        public int NormalMesai { get; set; }
    }
}
