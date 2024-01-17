using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSicilYetkiGrubuwithTerminal
    {
        public int YetkiId { get; set; }
        public string Ad { get; set; } = null!;
        public int SicilId { get; set; }
        public string Soyad { get; set; } = null!;
        public string TerminalAdi { get; set; } = null!;
        public int TerminalId { get; set; }
        public string YetkiAdi { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string YetkiAciklama { get; set; } = null!;
        public int BirimId { get; set; }
        public string Okod1 { get; set; } = null!;
        public string Okod2 { get; set; } = null!;
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int GorevId { get; set; }
        public int PozisyonId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
    }
}
