using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PersonelGirisCikisRaporu
    {
        public int TasnifId { get; set; }
        public bool Ucretli { get; set; }
        public int SicilId { get; set; }
        public DateTime GirisZamani { get; set; }
        public DateTime CikisZamani { get; set; }
        public int Sure { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int MesaiBas { get; set; }
        public int MesaiBit { get; set; }
        public int GecTolerans { get; set; }
        public int ErkenTolerans { get; set; }
        public string? MesaiAdi { get; set; }
        public string? IzinAdi { get; set; }
        public int Izintip { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int FazlaMesai { get; set; }
        public int Fm { get; set; }
        public string? PersonelNo { get; set; }
        public string? GorevAdi { get; set; }
        public int GorevId { get; set; }
        public int FirmaId { get; set; }
        public string? FirmaAdi { get; set; }
        public int BolumId { get; set; }
        public string? BolumAd { get; set; }
        public string? PozisyonAd { get; set; }
        public int PozisyonId { get; set; }
        public string? BirimAdi { get; set; }
        public int BirimId { get; set; }
        public int Tatil { get; set; }
        public int MesaiSuresi { get; set; }
        public int NormalMesaiSuresi { get; set; }
        public int ResmiTatil { get; set; }
        public string? IzinKodu { get; set; }
        public DateTime BasTarih { get; set; }
        public DateTime BitTarih { get; set; }
        public int DinlenmeSuresi { get; set; }
    }
}
