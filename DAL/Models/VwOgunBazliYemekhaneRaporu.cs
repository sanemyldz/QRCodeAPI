using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwOgunBazliYemekhaneRaporu
    {
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime Zaman { get; set; }
        public int BolumId { get; set; }
        public int PozisyonId { get; set; }
        public int FirmaId { get; set; }
        public int GorevId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int TerminalId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string TerminalAdi { get; set; } = null!;
        public int SicilId { get; set; }
        public string TcNo { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
    }
}
