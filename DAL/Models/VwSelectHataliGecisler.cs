using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectHataliGecisler
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int SicilId { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public string SicilNo { get; set; } = null!;
        public string TcKimlikNo { get; set; } = null!;
        public string Okod1 { get; set; } = null!;
        public int BolumId { get; set; }
        public string BolumAd { get; set; } = null!;
        public int FirmaId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int BirimId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public string MesaiAciklama { get; set; } = null!;
        public int MesaiId { get; set; }
        public int GecKalma { get; set; }
        public int ErkenCikma { get; set; }
        public int GecisYok { get; set; }
        public int CikisYok { get; set; }
        public DateTime MesaiTarih { get; set; }
        public string MesaiAdi { get; set; } = null!;
    }
}
