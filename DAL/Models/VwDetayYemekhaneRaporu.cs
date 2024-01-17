using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwDetayYemekhaneRaporu
    {
        public int Id { get; set; }
        public DateTime EventTime { get; set; }
        public int Dakika { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public int SicilId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string TerminalAdi { get; set; } = null!;
        public int TerminalId { get; set; }
        public int Adet { get; set; }
    }
}
