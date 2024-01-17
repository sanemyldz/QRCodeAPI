using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwPuantajAktarimCeka
    {
        public int Id { get; set; }
        public DateTime MesaiTarih { get; set; }
        public string MesaiAdi { get; set; } = null!;
        public int MesaiId { get; set; }
        public int ToplamDinlenmeSuresi { get; set; }
        public int MesaiSuresi { get; set; }
        public int HaftaSonuCalisma { get; set; }
        public int HaftaIciCalisma { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int GirisKayitTip { get; set; }
        public int CikisKayitTip { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public int SicilId { get; set; }
        public int EksikCalisma { get; set; }
        public int ErkenCikti { get; set; }
        public int FazlaCalisma { get; set; }
        public int GecGeldi { get; set; }
        public int HataliGecis { get; set; }
        public int TotalDinlenmeSure { get; set; }
        public int TotalIceridekiSure { get; set; }
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
        public int OglenMolaSure { get; set; }
        public DateTime MesaiBasSonrasiIlkGiris { get; set; }
        public DateTime MesaiBitOncesiSonCikis { get; set; }
        public DateTime IlkGiris { get; set; }
        public DateTime SonCikis { get; set; }
        public int TasnifId { get; set; }
        public string Okod1 { get; set; } = null!;
        public int Gorev { get; set; }
        public bool TatilDurumu { get; set; }
        public int ToplamIzinSuresi { get; set; }
        public string ResmiTatilAdi { get; set; } = null!;
        public int ResmiTatlId { get; set; }
        public string IzinDurumu { get; set; } = null!;
        public int UcretliIzinSure { get; set; }
        public int UcretsizIzinSure { get; set; }
        public string IzinKodu { get; set; } = null!;
        public int IzinIdList { get; set; }
        public bool Tamgun { get; set; }
        public string KartNo { get; set; } = null!;
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public bool Saatlikizin { get; set; }
        public string BolumAdiText { get; set; } = null!;
    }
}
