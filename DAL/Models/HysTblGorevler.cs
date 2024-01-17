using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HysTblGorevler
    {
        public HysTblGorevler()
        {
            HysTblSeyahatlers = new HashSet<HysTblSeyahatler>();
        }

        public int Id { get; set; }
        public string? Ad { get; set; }

        public virtual ICollection<HysTblSeyahatler> HysTblSeyahatlers { get; set; }
    }
}
