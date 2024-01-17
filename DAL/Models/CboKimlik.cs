using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CboKimlik
    {
        public CboKimlik()
        {
            Ziyaretcis = new HashSet<Ziyaretci>();
        }

        public int Id { get; set; }
        public string Ad { get; set; } = null!;

        public virtual ICollection<Ziyaretci> Ziyaretcis { get; set; }
    }
}
