using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SelectYetkİ
    {
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string LokasyonAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string? YetkiAdi { get; set; }
        public string TerminalAdi { get; set; } = null!;
    }
}
