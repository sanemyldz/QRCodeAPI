using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSirketBazliYemekhaneRaporu
    {
        public int FirmaId { get; set; }
        public string FirmaAd { get; set; } = null!;
        public int BolumId { get; set; }
        public string BolumAd { get; set; } = null!;
        public int TerminalId { get; set; }
        public string TerminalAd { get; set; } = null!;
        public int Adet { get; set; }
        public DateTime Tarih { get; set; }
    }
}
