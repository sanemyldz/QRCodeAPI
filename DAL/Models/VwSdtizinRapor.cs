using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSdtizinRapor
    {
        public int Id { get; set; }
        public string Adi { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public DateTime IsBaslama { get; set; }
        public DateTime IsBitis { get; set; }
        public DateTime MesaiTarih { get; set; }
        public string? BirimAdi { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public string PozisyonAd { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public int PozisyonId { get; set; }
        public int GorevId { get; set; }
        public int BolumId { get; set; }
        public int BirimId { get; set; }
        public string IzinAdi { get; set; } = null!;
        public int IzinTip { get; set; }
        public string Kod { get; set; } = null!;
        public int GirisId { get; set; }
        public int CikisId { get; set; }
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
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
        public int UcretliIzinSure { get; set; }
        public int UcretsizIzinSure { get; set; }
    }
}
