using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwPersonelPdksmail
    {
        public int SicilId { get; set; }
        public string SicilNo { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string PersonelNo { get; set; } = null!;
        public DateTime MesaiTarih { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int BirimId { get; set; }
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int PozisyonId { get; set; }
        public int GorevId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public int MesaiSuresi { get; set; }
        public int Tatil { get; set; }
        public int IzinId { get; set; }
        public string IzinAciklama { get; set; } = null!;
        public int IzinTip { get; set; }
        public string IzinTipAciklama { get; set; } = null!;
        public int ResmiTatil { get; set; }
        public string ResmiTatilAdi { get; set; } = null!;
        public int ToplamIceridekiSure { get; set; }
        public int GecGeldi { get; set; }
        public int ErkenCikti { get; set; }
        public int EksikCalisma { get; set; }
        public int FazlaCalisma { get; set; }
        public int TotalDinlenmeSure { get; set; }
        public int Sure { get; set; }
        public int ErkenFarkGercek { get; set; }
        public int GecFarkGercek { get; set; }
        public string MesaiAdi { get; set; } = null!;
        public int UcretliIzinSure { get; set; }
        public int UcretsizIzinSure { get; set; }
        public bool SaatlikIzin { get; set; }
        public DateTime BaslangicTarih { get; set; }
        public DateTime BitisTarih { get; set; }
    }
}
