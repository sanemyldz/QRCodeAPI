using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblIller
    {
        public int Id { get; set; }
        public int? IlKodu { get; set; }
        public string? IlAd { get; set; }
        public string? IlHaritaKod { get; set; }
        public string? IlBolgeKodu { get; set; }
    }
}
