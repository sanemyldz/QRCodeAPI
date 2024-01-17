using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwMerkezGunlukCalismaCizelgesi
    {
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime PersonelGiris { get; set; }
        public DateTime PersonelCikis { get; set; }
        public DateTime PersonelYemekCikis { get; set; }
        public DateTime PersonelYemekGiris { get; set; }
        public int IzinTip { get; set; }
        public string IzinAciklama { get; set; } = null!;
        public DateTime MesaiTarih { get; set; }
        public string? Tcno { get; set; }
        public string? SicilNo { get; set; }
        public int FirmaId { get; set; }
        public int GorevId { get; set; }
        public int BolumId { get; set; }
        public int? BirimId { get; set; }
        public int PozisyonId { get; set; }
    }
}
