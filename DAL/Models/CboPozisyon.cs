using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CboPozisyon
    {
        public CboPozisyon()
        {
            Sicils = new HashSet<Sicil>();
        }

        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public int? BolumId { get; set; }
        public int? StatuId { get; set; }
        public string? EntegrasyonKod { get; set; }

        public virtual ICollection<Sicil> Sicils { get; set; }
    }
}
