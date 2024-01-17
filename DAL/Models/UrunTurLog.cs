using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UrunTurLog
    {
        public int Id { get; set; }
        public int? KategoriId { get; set; }
        public string? Ad { get; set; }
        public int? DusumMiktar { get; set; }
        public decimal? Fiyat { get; set; }
        public int? FmGunlukAdetLimit { get; set; }
        public decimal? FmGunlukTutarLimit { get; set; }
        public int? FmAylikAdetLimit { get; set; }
        public decimal? FmAylikTutarLimit { get; set; }
        public int? UserId { get; set; }
        public DateTime? IslemTarih { get; set; }
        public byte? IslemTur { get; set; }
    }
}
