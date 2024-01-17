using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PeriyodikOdemeler
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public decimal? Cocuksayisi { get; set; }
        public decimal? YakacakYardimi { get; set; }
        public decimal? YolYardimi { get; set; }
        public decimal? PeriyodikYardim { get; set; }
        public decimal? Ikramiye { get; set; }
        public decimal? Avans { get; set; }

        public virtual Sicil Sicil { get; set; } = null!;
    }
}
