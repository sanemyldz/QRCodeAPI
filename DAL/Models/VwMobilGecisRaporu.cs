using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwMobilGecisRaporu
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? PersonelNo { get; set; }
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int PozisyonId { get; set; }
        public int GorevId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public DateTime? OlayZaman { get; set; }
        public byte? Type { get; set; }
        public byte? Yon { get; set; }
        public string? Enlem { get; set; }
        public string? Boylam { get; set; }
        public string? FotografYol { get; set; }
        public int? MobilTurId { get; set; }
    }
}
