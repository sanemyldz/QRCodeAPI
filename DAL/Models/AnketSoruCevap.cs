using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AnketSoruCevap
    {
        public AnketSoruCevap()
        {
            AnketSonucs = new HashSet<AnketSonuc>();
        }

        public int Id { get; set; }
        public int SoruId { get; set; }
        public string CevapMetni { get; set; } = null!;
        public int Sira { get; set; }
        public int? Olusturan { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public bool? Deleted { get; set; }

        public virtual AnketSoru Soru { get; set; } = null!;
        public virtual ICollection<AnketSonuc> AnketSonucs { get; set; }
    }
}
