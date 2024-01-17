using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AnketTanim
    {
        public AnketTanim()
        {
            AnketSonucs = new HashSet<AnketSonuc>();
            AnketSorus = new HashSet<AnketSoru>();
        }

        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public DateTime BaslanticTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int? Olusturan { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public bool? Deleted { get; set; }
        public string? Lokasyon { get; set; }
        public bool? Aktif { get; set; }

        public virtual ICollection<AnketSonuc> AnketSonucs { get; set; }
        public virtual ICollection<AnketSoru> AnketSorus { get; set; }
    }
}
