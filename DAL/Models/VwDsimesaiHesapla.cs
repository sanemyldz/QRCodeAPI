using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwDsimesaiHesapla
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime IzinBaslangic { get; set; }
        public DateTime IzinBitis { get; set; }
        public string IzinAciklama { get; set; } = null!;
        public string MesaiAciklama { get; set; } = null!;
        public int IzinSure { get; set; }
        public int Birimid { get; set; }
        public DateTime MesaiTarih { get; set; }
        public string? Tc { get; set; }
        public string? SicilNo { get; set; }
        public int SicilId { get; set; }
        public int IzinTipId { get; set; }
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int Pozisyonid { get; set; }
        public int GorevId { get; set; }
    }
}
