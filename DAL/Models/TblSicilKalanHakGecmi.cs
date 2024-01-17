using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilKalanHakGecmi
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public decimal? EskiIcecekBakiye { get; set; }
        public decimal? EskiYiyecekBakiye { get; set; }
        public DateTime? SifirlamaTarih { get; set; }
    }
}
