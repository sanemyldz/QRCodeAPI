using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSaatlikIzinCizelgesi
    {
        public string? SicilNo { get; set; }
        public string? PersonelNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int SicilId { get; set; }
        public string MesaiAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public int FirmaId { get; set; }
        public int BirimId { get; set; }
        public int PozisyonId { get; set; }
        public int GorevId { get; set; }
        public int IzinTipId { get; set; }
        public string? IzinAdi { get; set; }
        public DateTime IzinBaslangicTarihi { get; set; }
        public DateTime IzinBitisTarihi { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int IzinSure { get; set; }
        public int MesaiBirimi { get; set; }
    }
}
