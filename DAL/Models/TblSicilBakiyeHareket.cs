using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilBakiyeHareket
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public decimal? EklenenIcecekBakiye { get; set; }
        public decimal? EklenenYiyecekBakiye { get; set; }
        public int? IslemTur { get; set; }
        public DateTime? Tarih { get; set; }
    }
}
