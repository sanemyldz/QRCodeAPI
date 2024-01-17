using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwOdaBazliGecisListesi
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public int SicilId { get; set; }
        public int FirmaId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BirimId { get; set; }
        public string? BirimAdi { get; set; }
        public int OdaId { get; set; }
        public string? OdaAdi { get; set; }
        public string TerminalAdi { get; set; } = null!;
        public DateTime EventTime { get; set; }
    }
}
