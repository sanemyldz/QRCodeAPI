using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwCihazDurumRapor
    {
        public string Name { get; set; } = null!;
        public string Port { get; set; } = null!;
        public DateTime? Zaman { get; set; }
        public int? Ping { get; set; }
        public string Durum { get; set; } = null!;
        public string SourceName { get; set; } = null!;
        public DateTime LastEventTime { get; set; }
    }
}
