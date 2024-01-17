using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAselsanRapor
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int TasnifMesaiBirim { get; set; }
        public int MesaiBaslangic { get; set; }
        public int IzinTipId { get; set; }
        public string? IzinKod { get; set; }
        public int TasnifIzinTip { get; set; }
        public int MesaiSuresi { get; set; }
        public int GecGeldi { get; set; }
        public int ErkenCikti { get; set; }
        public int FazlaCalisma { get; set; }
        public int EksikCalisma { get; set; }
        public DateTime IlkGiris { get; set; }
        public DateTime SonCikis { get; set; }
        public int MesaiId { get; set; }
        public string? BirimAdi { get; set; }
        public int BirimId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
    }
}
