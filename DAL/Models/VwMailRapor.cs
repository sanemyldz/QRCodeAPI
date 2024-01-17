using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwMailRapor
    {
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? BirimAdi { get; set; }
        public int BirimId { get; set; }
        public string? SicilNo { get; set; }
        public string? TcNo { get; set; }
        public int SicilId { get; set; }
        public string? BolumAdi { get; set; }
        public int BolumId { get; set; }
        public string? MesaiAdi { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public string? GorevAdi { get; set; }
        public int GorevId { get; set; }
        public string? FirmaAdi { get; set; }
        public int FirmaId { get; set; }
        public string? PozisyonAdi { get; set; }
        public int PozisyonId { get; set; }
        public int Tolerans { get; set; }
        public DateTime? MesaiBas { get; set; }
        public DateTime? MesaiBit { get; set; }
        public DateTime? Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public string? GirisStr { get; set; }
        public string? CikisStr { get; set; }
        public int IzinId { get; set; }
        public string? IzinAciklama { get; set; }
        public string? ErkenDurum { get; set; }
        public string? IzinDurum { get; set; }
        public string? FirmaAd { get; set; }
        public string? PozisyonAd { get; set; }
        public string? IzinAdi { get; set; }
        public int MesaiSuresiDk { get; set; }
        public int NormalMesai { get; set; }
        public int ToplamCalisilanSure { get; set; }
        public string? Aciklama { get; set; }
        public int EksikSure { get; set; }
        public int ErkenTolerans { get; set; }
        public int GecTolerans { get; set; }
        public int Sure { get; set; }
        public string? DevamsizText { get; set; }
        public int GecFark { get; set; }
        public int MesaiBitis { get; set; }
        public int MesaiBaslangic { get; set; }
        public string? PersonelNo { get; set; }
        public int TasnifId { get; set; }
        public string? MesaiGrubAciklama { get; set; }
        public int ErkenFarkToleransli { get; set; }
        public int ErkenFarkGercek { get; set; }
        public int EksikGun { get; set; }
        public int ResmiTatil { get; set; }
        public string? ResmiTatilAdi { get; set; }
        public int Tatil { get; set; }
        public int GecFarkGercek { get; set; }
        public int GecFarkToleransli { get; set; }
        public string? TcKimlikNo { get; set; }
        public int ErkenCikma { get; set; }
        public int ErkenCikti { get; set; }
        public int EksikCalisma { get; set; }
        public int GecGelme { get; set; }
        public int GecGeldi { get; set; }
        public DateTime? Zaman { get; set; }
        public int DinlenmeSure { get; set; }
        public string? TerminalAdi { get; set; }
        public int TerminalId { get; set; }
        public int Yonu { get; set; }
        public int EsikSure { get; set; }
        public int ToplamIceridekiSure { get; set; }
        public DateTime? IzinBaslangic { get; set; }
        public DateTime? IzinBitis { get; set; }
        public int FazlaCalisma { get; set; }
        public string? IzinDurumu { get; set; }
        public int GirisId { get; set; }
        public int CikisId { get; set; }
        public int Id { get; set; }
        public string? Adi { get; set; }
        public int IzinTip { get; set; }
        public string? Kod { get; set; }
        public int TotalIceridekiSure { get; set; }
        public int MesaiSuresi { get; set; }
        public int UcretliIzinSure { get; set; }
        public int UcretsizIzinSure { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public DateTime? GirisTarih { get; set; }
        public DateTime? MolaGirisZamani { get; set; }
        public DateTime? MolaCikisZamani { get; set; }
        public string? GirisTerminalAdi { get; set; }
        public string? CikisTerminalAdi { get; set; }
    }
}
