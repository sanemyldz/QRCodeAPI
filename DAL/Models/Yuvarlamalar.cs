using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Yuvarlamalar
    {
        public int Id { get; set; }
        public int MesaiId { get; set; }
        public DateTime Saat1 { get; set; }
        public DateTime Saat2 { get; set; }
        public DateTime Saat3 { get; set; }
        public int Hedef { get; set; }

        public virtual Mesailer Mesai { get; set; } = null!;
    }
}
