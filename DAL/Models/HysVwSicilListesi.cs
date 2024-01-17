using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HysVwSicilListesi
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public int? BolumId { get; set; }
        public string? BolumAdi { get; set; }
        public int? GorevId { get; set; }
        public string? GorevAdi { get; set; }
        public int? BirimId { get; set; }
        public string? BirimAdi { get; set; }
        public int? FirmaId { get; set; }
        public string? FirmaAdi { get; set; }
        public int? Surec0Id { get; set; }
        public string? Surec0Adi { get; set; }
        public int? Surec1Id { get; set; }
        public string? Surec1Adi { get; set; }
    }
}
