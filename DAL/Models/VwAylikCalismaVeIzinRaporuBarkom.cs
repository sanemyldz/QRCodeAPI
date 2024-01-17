using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAylikCalismaVeIzinRaporuBarkom
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int BirimId { get; set; }
        public string? BirimAdi { get; set; }
        public string? SicilNo { get; set; }
        public string? Aciklama { get; set; }
        public string? PersonelNo { get; set; }
        public string? Tcno { get; set; }
        public DateTime Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public DateTime CikisTarih { get; set; }
        public string CardId { get; set; } = null!;
        public DateTime GirisTarih { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public int CalismaDurumu { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int BolumId { get; set; }
        public string BolumAd { get; set; } = null!;
        public string FirmaAd { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public string PozisyonAd { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public int Tolerans { get; set; }
        public int FirmaId { get; set; }
        public int? GecTolerans { get; set; }
        public int? ErkenTolerans { get; set; }
        public string IzinAciklama { get; set; } = null!;
        public int IzinTip { get; set; }
        public int IzinId { get; set; }
        public int ResmiTatil { get; set; }
        public int Tatil { get; set; }
        public string IzinKodu { get; set; } = null!;
        public int CikisYapanSayi { get; set; }
        public int GirisYapanSayi { get; set; }
        public int FazlaMesai { get; set; }
        public decimal ToplamKalanIzinGun { get; set; }
        public decimal ToplamKullanilanIzinGun { get; set; }
        public decimal ToplamHakEdilenIzinGun { get; set; }
        public decimal IzinGun { get; set; }
        public int IzinSuresi { get; set; }
    }
}
