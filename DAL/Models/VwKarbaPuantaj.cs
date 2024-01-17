using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwKarbaPuantaj
    {
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string Tcno { get; set; } = null!;
        public int? BirimId { get; set; }
        public int? FirmaId { get; set; }
        public int? BolumId { get; set; }
        public int? GorevId { get; set; }
        public int? PozisyonId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int GirisKayitTipi { get; set; }
        public DateTime Giris { get; set; }
        public int CikisKayitTipi { get; set; }
        public DateTime Cikis { get; set; }
        public int MesaiSuresi { get; set; }
        public int FazlaCalisma { get; set; }
        public int TotalIceridekiSure { get; set; }
        public int? TotalDinlenmeSure { get; set; }
        public int HaftaTatili { get; set; }
        public int ResmiTatil { get; set; }
        public int IzinId { get; set; }
        public int IzinTipId { get; set; }
        public string IzinKod { get; set; } = null!;
        public string IzinTipAciklama { get; set; } = null!;
        public bool Ucretli { get; set; }
        public string BirimAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public int EksikCalisma { get; set; }
        public int GecGeldi { get; set; }
        public int ErkenCikti { get; set; }
        public string IzinAciklama { get; set; } = null!;
        public bool Saatlikizin { get; set; }
        public int IzinBaslangic { get; set; }
        public int IzinBitis { get; set; }
        public DateTime IzinBasTarih { get; set; }
        public DateTime IzinBitTarih { get; set; }
        public string CardId { get; set; } = null!;
        public string MesaiAciklama { get; set; } = null!;
        public decimal IzinGun { get; set; }
        public int ToplamIzinSuresi { get; set; }
        public int UcretliIzinSure { get; set; }
        public int UcretsizIzinSure { get; set; }
        public int OnaylananFazlaMesai { get; set; }
        public int MesaiIciToplamIcerdekiSure { get; set; }
        public int MesaiOncesiToplamIcerdekiSure { get; set; }
        public int MesaiDisiToplamIcerdekiSure { get; set; }
        public int MesaiBas { get; set; }
        public int MesaiBit { get; set; }
        public int DinlenmeSure { get; set; }
        public int MaxDinlenme { get; set; }
        public int MaxGiris { get; set; }
        public int MinCikis { get; set; }
        public int IzinDinlenme { get; set; }
    }
}
