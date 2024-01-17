using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAylikDevam
    {
        public int BolumId { get; set; }
        public string BolumAd { get; set; } = null!;
        public int BirimId { get; set; }
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public int TasniflemeId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int ResmiTatil { get; set; }
        public int Tatil { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public string IzınId { get; set; } = null!;
        public int IzinTip { get; set; }
        public string IzinAciklama { get; set; } = null!;
    }
}
