using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UrunSicilHakedi
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public int? IcecekHakedis { get; set; }
        public int? YiyecekHakedis { get; set; }
        public int? Tarih { get; set; }

        public virtual Sicil? Sicil { get; set; }
    }
}
