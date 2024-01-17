using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CboSicil
    {
        public CboSicil()
        {
            SicilAttaches = new HashSet<SicilAttach>();
        }

        public int Id { get; set; }
        public string Ad { get; set; } = null!;

        public virtual ICollection<SicilAttach> SicilAttaches { get; set; }
    }
}
