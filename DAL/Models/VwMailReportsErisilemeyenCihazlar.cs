using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwMailReportsErisilemeyenCihazlar
    {
        public int Id { get; set; }
        public string TerminalAdi { get; set; } = null!;
        public string? LokasyonAdi { get; set; }
        public DateTime? Zaman { get; set; }
    }
}
