using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectTerminalYetki
    {
        public int Id { get; set; }
        public string? YetkiDurum { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? PersonelNo { get; set; }
        public int? BirimId { get; set; }
        public string Name { get; set; } = null!;
        public string YetkiAdi { get; set; } = null!;
        public int TerminalId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string? BirimAdi { get; set; }
        public int? GrupId { get; set; }
        public int? LokasyonId { get; set; }
    }
}
