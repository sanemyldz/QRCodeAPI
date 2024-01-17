using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HesaplamaTipleri
    {
        public HesaplamaTipleri()
        {
            Mesailers = new HashSet<Mesailer>();
        }

        public int Id { get; set; }
        public string HesaplamaTip { get; set; } = null!;
        public bool Aktif { get; set; }

        public virtual ICollection<Mesailer> Mesailers { get; set; }
    }
}
