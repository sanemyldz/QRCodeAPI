using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwIceridekiSureBazliPuantaj
    {
        public int TasnifId { get; set; }
        public int MesaiOzetId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public string Aciklama { get; set; } = null!;
        public int GunNo { get; set; }
        public int MesaiId { get; set; }
        public string Devamsiz { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public int SicilId { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public int GecSure { get; set; }
        public int ErkenSure { get; set; }
        public int EksikCalisma { get; set; }
        public int ErkenCikti { get; set; }
        public int FazlaCalisma { get; set; }
        public int GecGeldi { get; set; }
        public int TotalDinlenmeSure { get; set; }
        public int OglenMolaSure { get; set; }
        public int TotalIceridekiSure { get; set; }
        public int MesaiSuresi { get; set; }
        public int GecTolerans { get; set; }
        public int ErkenTolerans { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public int BirimId { get; set; }
        public bool Ucretli { get; set; }
        public string IzinAdi { get; set; } = null!;
        public string MesaiAciklama { get; set; } = null!;
        public DateTime IlkGiris { get; set; }
        public DateTime SonCikis { get; set; }
        public DateTime GirisTarih { get; set; }
        public DateTime CikisTarih { get; set; }
        public string Okod1 { get; set; } = null!;
        public int Gorev { get; set; }
        public int TatilDurumu { get; set; }
        public int ResmiTatil { get; set; }
        public string IzinDurumu { get; set; } = null!;
        public string IzinDetayAciklama { get; set; } = null!;
        public int UcretliSure { get; set; }
        public int UcretsizSure { get; set; }
        public int MesaiIciToplamIcerdekiSure { get; set; }
        public int MesaiDisiToplamIcerdekiSure { get; set; }
        public int MesaiOncesiToplamIcerdekiSure { get; set; }
        public bool SaatlikIzin { get; set; }
        public int IzinId { get; set; }
        public DateTime IzinBasTarih { get; set; }
        public DateTime IzinBitTarih { get; set; }
    }
}
