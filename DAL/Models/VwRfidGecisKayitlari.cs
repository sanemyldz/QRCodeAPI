using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwRfidGecisKayitlari
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string AracPlaka { get; set; } = null!;
        public string KartNo { get; set; } = null!;
        public string FacilityCode { get; set; } = null!;
        public string TerminalAdi { get; set; } = null!;
        public int TerminalId { get; set; }
        public string TerminalYonu { get; set; } = null!;
        public DateTime EventTime { get; set; }
        public string Soyad { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string LokasyonAdi { get; set; } = null!;
    }
}
