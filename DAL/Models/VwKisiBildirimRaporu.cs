using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwKisiBildirimRaporu
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string? SicilNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? Tckn { get; set; }
        public string? Cinsiyet { get; set; }
        public string? BabaAdi { get; set; }
        public string? DogumYeri { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public string GorevAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public int Uyruk { get; set; }
        public string KayitDurumu { get; set; } = null!;
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int GorevId { get; set; }
        public int PozisyonId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public int BirimId { get; set; }
        public string GorevTuru { get; set; } = null!;
        public int TaseronFirmaId { get; set; }
    }
}
