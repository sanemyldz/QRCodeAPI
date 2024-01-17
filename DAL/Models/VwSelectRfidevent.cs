using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectRfidevent
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string LokasyonAdi { get; set; } = null!;
        public string AracPlaka { get; set; } = null!;
        public string Rfidad { get; set; } = null!;
        public string Rfidsoyad { get; set; } = null!;
        public int SicilId { get; set; }
        public int AracId { get; set; }
        public DateTime EventTime { get; set; }
        public string? CardId { get; set; }
        public string? FacilityCode { get; set; }
        public string? Aciklama { get; set; }
        public int TerminalId { get; set; }
        public string Name { get; set; } = null!;
        public string Yon { get; set; } = null!;
    }
}
