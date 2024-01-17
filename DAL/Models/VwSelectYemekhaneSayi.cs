using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectYemekhaneSayi
    {
        public int SicilId { get; set; }
        public DateTime EventTime { get; set; }
        public string Adi { get; set; } = null!;
        public string Soyadi { get; set; } = null!;
        public string? SicilNo { get; set; }
        public int TerminalGrubu { get; set; }
        public string? BolumAdi { get; set; }
        public string? FirmaAdi { get; set; }
        public string? GorevAdi { get; set; }
        public string? PozisyonAdi { get; set; }
        public int FirmaId { get; set; }
        public int GorevId { get; set; }
        public int PozisyonId { get; set; }
        public int BolumId { get; set; }
    }
}
