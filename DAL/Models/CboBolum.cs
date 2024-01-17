using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CboBolum
    {
        public CboBolum()
        {
            Sicils = new HashSet<Sicil>();
        }

        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public int? PeriyodId { get; set; }
        public string? EntegrasyonKod { get; set; }
        public string? Okod1 { get; set; }

        public virtual ICollection<Sicil> Sicils { get; set; }
    }
}
