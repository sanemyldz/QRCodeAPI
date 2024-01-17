using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UrunTur
    {
        public UrunTur()
        {
            UrunSiparisDetays = new HashSet<UrunSiparisDetay>();
        }

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
        public bool? Aktif { get; set; }

        public virtual ICollection<UrunSiparisDetay> UrunSiparisDetays { get; set; }
    }
}
