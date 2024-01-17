using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectGecisTerminalBazli
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? PersonelNo { get; set; }
        public int? BirimId { get; set; }
        public string? Okod1 { get; set; }
        public string? Okod2 { get; set; }
        public string? Okod3 { get; set; }
        public string? Okod4 { get; set; }
        public string? Okod5 { get; set; }
        public DateTime EventTime { get; set; }
        public int TerminalId { get; set; }
        public string? Name { get; set; }
        public string? FirmaAdi { get; set; }
        public int? FirmaId { get; set; }
        public string? BolumAdi { get; set; }
        public int? BolumId { get; set; }
        public string? PozisyonAdi { get; set; }
        public int? PozisyonId { get; set; }
        public string? GorevAdi { get; set; }
        public int? GorevId { get; set; }
        public string? YetkiAdi { get; set; }
        public string EventCode { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public string GrupAdi { get; set; } = null!;
        public int TerminalGrupId { get; set; }
    }
}
