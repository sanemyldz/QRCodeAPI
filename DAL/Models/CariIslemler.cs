using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CariIslemler
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int? Ba { get; set; }
        public int? Tutar { get; set; }
        public DateTime? Tarih { get; set; }
        public string? IslemNo { get; set; }
        public bool? Aktif { get; set; }
        public string? Aciklama { get; set; }

        public virtual Sicil Sicil { get; set; } = null!;
    }
}
