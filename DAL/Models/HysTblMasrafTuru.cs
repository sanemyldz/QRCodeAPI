using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HysTblMasrafTuru
    {
        public HysTblMasrafTuru()
        {
            HysTblMasraflars = new HashSet<HysTblMasraflar>();
        }

        public int Id { get; set; }
        public string? Ad { get; set; }

        public virtual ICollection<HysTblMasraflar> HysTblMasraflars { get; set; }
    }
}
