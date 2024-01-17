using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwMolaSuresiSelect
    {
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? PersonelNo { get; set; }
        public int FirmaId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public int SicilId { get; set; }
        public DateTime? Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public int MolaSayi { get; set; }
        public int TotalMolaSayi { get; set; }
        public int TotalMolaSure { get; set; }
        public DateTime? OglenBaslangic { get; set; }
        public DateTime? OglenBitis { get; set; }
        public DateTime? MesaiGiris { get; set; }
        public DateTime? MesaiCikis { get; set; }
        public DateTime? MesaiBas { get; set; }
        public DateTime? MesaiBit { get; set; }
        public int MesaiSureInc { get; set; }
        public int? MesaiSure { get; set; }
    }
}
