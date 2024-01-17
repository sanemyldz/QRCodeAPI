using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectDetayMesaiHesaplama
    {
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public int GunlukMesaiId { get; set; }
        public int GunId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int GirisKayitTip { get; set; }
        public int CikisKayitTip { get; set; }
        public int NormalMesaiSuresi { get; set; }
        public int MesaiOzetiId { get; set; }
        public string MesaiAdi { get; set; } = null!;
        public int MesaiId { get; set; }
        public int ToplamDinlenmeSuresi { get; set; }
        public int MesaiSuresi { get; set; }
        public int EksikCalisma { get; set; }
        public int ErkenCikti { get; set; }
        public int FazlaCalisma { get; set; }
        public int GecGeldi { get; set; }
        public int HataliGecis { get; set; }
        public int YillikIzinSure { get; set; }
        public int RaporluIzinSure { get; set; }
        public int TotalDinlenmeSure { get; set; }
        public int TotalIceridekiSure { get; set; }
        public int OglenMolaSure { get; set; }
        public DateTime MesaiBasSonrasiIlkGiris { get; set; }
        public DateTime MesaiBitOncesiSonCikis { get; set; }
        public int TasnifId { get; set; }
        public int TatilDurumu { get; set; }
        public int ResmiTatil { get; set; }
        public int ToplamIzinSuresi { get; set; }
        public string ResmiTatilAdi { get; set; } = null!;
        public int ResmiTatlId { get; set; }
        public int UcretliIzinSure { get; set; }
        public int UcretsizIzinSure { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string? BirimAdi { get; set; }
        public int BirimId { get; set; }
        public int IzinId { get; set; }
        public DateTime IzinBaslangic { get; set; }
        public DateTime IzinBitis { get; set; }
        public string IzinKod { get; set; } = null!;
        public bool UcretliIzin { get; set; }
        public bool Tamgun { get; set; }
        public bool SaatlikIzin { get; set; }
    }
}
