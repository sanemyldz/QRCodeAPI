using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwWcgecisler
    {
        public DateTime Tarih { get; set; }
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? Idno { get; set; }
        public string Lokasyon { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public string? TerminalAdiGiris { get; set; }
        public DateTime Giris { get; set; }
        public string? TerminalAdiCikis { get; set; }
        public DateTime Cikis { get; set; }
        public int IcerdeKalinanSure { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int PozisyonId { get; set; }
        public int LokasyonId { get; set; }
        public int BirimId { get; set; }
    }
}
