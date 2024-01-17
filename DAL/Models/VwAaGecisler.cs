using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAaGecisler
    {
        public string? SicilNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int? BirimId { get; set; }
        public string? BirimAdi { get; set; }
        public int TerminalId { get; set; }
        public string TerminalAdi { get; set; } = null!;
        public int Yon { get; set; }
        public DateTime? GecisTarih { get; set; }
        public TimeSpan? GecisSaat { get; set; }
        public DateTime EventTime { get; set; }
        public int EventIndex { get; set; }
    }
}
