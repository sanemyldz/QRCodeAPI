using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwIzinTalepFormuOlustur
    {
        public int Id { get; set; }
        public int IzinAkisId { get; set; }
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? PersonelNo { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public int FirmaId { get; set; }
        public int GorevId { get; set; }
        public int PozisyonId { get; set; }
        public int BolumId { get; set; }
        public int BirimId { get; set; }
        public DateTime IseGirisTarih { get; set; }
        public string IzinTuru { get; set; } = null!;
        public string? IzinAciklama { get; set; }
        public DateTime BasTarih { get; set; }
        public DateTime BitTarih { get; set; }
        public DateTime IseBaslamaTarih { get; set; }
        public bool Saatlikizin { get; set; }
        public decimal GunSure { get; set; }
        public int SaatlikSure { get; set; }
        public string OnayAdSoyad { get; set; } = null!;
        public int OnaySiraNo { get; set; }
        public decimal ToplamHakEdilenIzinGun { get; set; }
        public decimal ToplamKullanilanIzinGun { get; set; }
        public decimal ToplamKalanIzinGun { get; set; }
        public decimal BakiyeFarkiGun { get; set; }
    }
}
