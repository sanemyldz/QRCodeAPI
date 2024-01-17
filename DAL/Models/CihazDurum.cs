using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CihazDurum
    {
        public string Name { get; set; } = null!;
        public string Port { get; set; } = null!;
        public DateTime? Zaman { get; set; }
        public int? Ping { get; set; }
        public string Durum { get; set; } = null!;
    }
}
