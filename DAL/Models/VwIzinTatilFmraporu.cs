using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwIzinTatilFmraporu
    {
        public int SicilId { get; set; }
        public string SicilNo { get; set; } = null!;
        public string Tcno { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int IzinTipId { get; set; }
        public string IzinKod { get; set; } = null!;
        public string IzinAciklama { get; set; } = null!;
        public int ErkenCikti { get; set; }
        public int EksikCalisma { get; set; }
        public int FazlaCalisma { get; set; }
        public int MesaiSuresi { get; set; }
        public int TotalIcerdekiSure { get; set; }
        public int TotalDinlenmeSure { get; set; }
        public int GerceklesenMesaiId { get; set; }
        public int GunlukMesaiId { get; set; }
        public int TasnifId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int GunNo { get; set; }
        public int IzinId { get; set; }
        public bool Ucretli { get; set; }
        public int ResmiTatil { get; set; }
        public int Tatil { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public int BirimId { get; set; }
        public int BolumId { get; set; }
        public int FirmaId { get; set; }
        public int PozisyonId { get; set; }
        public int GorevId { get; set; }
        public int MesaiBas { get; set; }
        public int MesaiBit { get; set; }
        public bool OncekiGunMesaisi { get; set; }
        public DateTime Cikis { get; set; }
        public DateTime Giris { get; set; }
        public int MesaiCikis { get; set; }
        public int MesaiGiris { get; set; }
    }
}
