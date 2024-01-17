using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UrunSiparisDetay
    {
        public int Id { get; set; }
        public int? UrunSiparisId { get; set; }
        public int? UrunTurId { get; set; }
        public int? SicilId { get; set; }
        public bool? MesaiDisi { get; set; }
        public int? Adet { get; set; }
        public decimal? Fiyat { get; set; }
        public bool? Onaylandi { get; set; }
        public int? Onaylayan { get; set; }
        public DateTime? OnayTarih { get; set; }
        public int? YakaId { get; set; }
        public byte? Tip { get; set; }

        public virtual Sicil? Sicil { get; set; }
        public virtual UrunSipari? UrunSiparis { get; set; }
        public virtual UrunTur? UrunTur { get; set; }
    }
}
