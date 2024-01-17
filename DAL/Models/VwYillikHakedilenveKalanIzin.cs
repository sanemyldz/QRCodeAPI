using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwYillikHakedilenveKalanIzin
    {
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string PersonelNo { get; set; } = null!;
        public int BirimId { get; set; }
        public string BirimAd { get; set; } = null!;
        public int FirmaId { get; set; }
        public string FirmaAd { get; set; } = null!;
        public int BolumId { get; set; }
        public string BolumAd { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAd { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAd { get; set; } = null!;
        public int IzinKuralId { get; set; }
        public string IzinKuralAd { get; set; } = null!;
        public decimal HakEdilenGun { get; set; }
        public decimal KalanIzinGun { get; set; }
        public DateTime DogumTarih { get; set; }
        public DateTime GirisTarih { get; set; }
        public decimal BakiyeFarkiGun { get; set; }
        public decimal ToplamKullanilanIzinGun { get; set; }
        public int YillikHakEdilenIzinGun { get; set; }
        public DateTime YillikHakEdilenTarih { get; set; }
        public int IzinId { get; set; }
        public bool Saatlik { get; set; }
        public DateTime BasTarih { get; set; }
        public DateTime BitTarih { get; set; }
        public string Aciklama { get; set; } = null!;
        public decimal Gun { get; set; }
    }
}
