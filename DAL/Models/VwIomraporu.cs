using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwIomraporu
    {
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public DateTime IsBaslangic { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public string Pozisyon { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string Bolum { get; set; } = null!;
        public int BolumId { get; set; }
        public string Firma { get; set; } = null!;
        public int FirmaId { get; set; }
        public string Gorev { get; set; } = null!;
        public int GorevId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int DinlenmeSure { get; set; }
        public int ToplamIceridekiSure { get; set; }
        public DateTime IzinBaslangic { get; set; }
        public DateTime IzinBitis { get; set; }
        public string IzinDurum { get; set; } = null!;
        public int ErkenCikma { get; set; }
        public int GecGelme { get; set; }
        public int MesaiSure { get; set; }
        public int EsikSure { get; set; }
        public int EksikCalisma { get; set; }
        public int FazlaCalisma { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public bool UcretliIzin { get; set; }
        public string Aciklama { get; set; } = null!;
        public DateTime MesaiBas { get; set; }
        public DateTime MesaiBit { get; set; }
        public int DinlenmeBaslangicSure { get; set; }
        public int DinlenmeBitisSure { get; set; }
        public DateTime OglenCikis { get; set; }
        public DateTime OglenGiris { get; set; }
        public DateTime? AraGirisZaman { get; set; }
        public DateTime? AraCikisZaman { get; set; }
        public string AraGirisTerminal { get; set; } = null!;
        public string AraCikisTerminal { get; set; } = null!;
        public string Okod1 { get; set; } = null!;
        public string Okod2 { get; set; } = null!;
        public string Okod3 { get; set; } = null!;
        public string Okod4 { get; set; } = null!;
        public string Okod5 { get; set; } = null!;
        public string Okod6 { get; set; } = null!;
    }
}
