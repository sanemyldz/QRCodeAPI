using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectPool
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int FirmaId { get; set; }
        public int GorevId { get; set; }
        public DateTime EventTime { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int Bölüm { get; set; }
        public string? SicilNo { get; set; }
        public int Yaka { get; set; }
        public string? TerminalNo { get; set; }
        public string? FixedSicilNo { get; set; }
        public string Kod { get; set; } = null!;
        public string FirmaAd { get; set; } = null!;
        public string GorevAd { get; set; } = null!;
        public string PozisyonAd { get; set; } = null!;
        public string BolumAd { get; set; } = null!;
        public string BirimAd { get; set; } = null!;
        public int BirimId { get; set; }
        public int PozisyonId { get; set; }
        public string Tcno { get; set; } = null!;
        public string TerminalAd { get; set; } = null!;
    }
}
