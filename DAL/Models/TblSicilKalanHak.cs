using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilKalanHak
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public int? IcecekKalanHak { get; set; }
        public int? YiyecekKalanHak { get; set; }
        public decimal? IcecekBakiye { get; set; }
        public decimal? YiyecekBakiye { get; set; }

        public virtual Sicil? Sicil { get; set; }
    }
}
