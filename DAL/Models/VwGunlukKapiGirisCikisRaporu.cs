using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGunlukKapiGirisCikisRaporu
    {
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string? BirimAdi { get; set; }
        public int BirimId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public int? ErkenCikti { get; set; }
        public int? GecGeldi { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public string? BolumOkod1 { get; set; }
        public string? SicilOkod8 { get; set; }
        public string? SicilOkod6 { get; set; }
    }
}
