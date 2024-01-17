using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MobilKomutGrup
    {
        public MobilKomutGrup()
        {
            MobilKomuts = new HashSet<MobilKomut>();
        }

        public int Id { get; set; }
        public string? Ad { get; set; }
        public bool? Aktif { get; set; }

        public virtual ICollection<MobilKomut> MobilKomuts { get; set; }
    }
}
