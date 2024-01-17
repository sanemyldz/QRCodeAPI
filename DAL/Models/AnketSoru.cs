using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AnketSoru
    {
        public AnketSoru()
        {
            AnketSonucs = new HashSet<AnketSonuc>();
            AnketSoruCevaps = new HashSet<AnketSoruCevap>();
        }

        public int Id { get; set; }
        public int AnketId { get; set; }
        public string SoruMetni { get; set; } = null!;
        public int Tip { get; set; }
        public int Sira { get; set; }
        public int? Olusturan { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public bool? Deleted { get; set; }

        public virtual AnketTanim Anket { get; set; } = null!;
        public virtual ICollection<AnketSonuc> AnketSonucs { get; set; }
        public virtual ICollection<AnketSoruCevap> AnketSoruCevaps { get; set; }
    }
}
