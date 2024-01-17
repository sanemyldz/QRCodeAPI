using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwToplamOdalardakiSicilSayisi
    {
        public int OdaId { get; set; }
        public string? OdaAdi { get; set; }
        public string? Ad { get; set; }
        public string Soyad { get; set; } = null!;
        public DateTime? SonGecis { get; set; }
        public string? TerminalAdi { get; set; }
        public int? IceridekiSayi { get; set; }
    }
}
