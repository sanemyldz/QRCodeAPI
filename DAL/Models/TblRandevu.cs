using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblRandevu
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public int? ZiyaretciId { get; set; }
        public DateTime? RandevuZamani { get; set; }
        public bool? Durum { get; set; }
        public string? RandevuNedeni { get; set; }
    }
}
