using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CboGorev
    {
        public CboGorev()
        {
            Sicils = new HashSet<Sicil>();
        }

        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public int? SirketId { get; set; }
        public DateTime? Baslangic { get; set; }
        public DateTime? Bitis { get; set; }
        public int? Sabah { get; set; }
        public int? Oglen { get; set; }
        public int? Aksam { get; set; }
        public int? Gece { get; set; }
        public int? Toplam { get; set; }
        public int? TopluAlim { get; set; }
        public int? Ziyaretci { get; set; }
        public string? EntegrasyonKod { get; set; }

        public virtual ICollection<Sicil> Sicils { get; set; }
    }
}
