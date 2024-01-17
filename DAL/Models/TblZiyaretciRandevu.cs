using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblZiyaretciRandevu
    {
        public int Id { get; set; }
        public string RandevuTcKimlik { get; set; } = null!;
        public DateTime KayitTarihi { get; set; }
        public string ZiyaretciAdi { get; set; } = null!;
        public string ZiyaretciSoyadi { get; set; } = null!;
        public string ZiyaretciTcno { get; set; } = null!;
        public DateTime RandevuTarihi { get; set; }
        public int Yapildi { get; set; }
        public int? ZiyaretciId { get; set; }
        public string? RandevuNedeni { get; set; }
    }
}
