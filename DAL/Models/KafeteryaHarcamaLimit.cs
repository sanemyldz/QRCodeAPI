using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KafeteryaHarcamaLimit
    {
        public byte Id { get; set; }
        public string? YakaTip { get; set; }
        public decimal? GunlukLimit { get; set; }
        public decimal? AylikLimit { get; set; }
    }
}
