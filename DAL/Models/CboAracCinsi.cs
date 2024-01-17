using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CboAracCinsi
    {
        public CboAracCinsi()
        {
            Aracs = new HashSet<Arac>();
        }

        public int Id { get; set; }
        public string Ad { get; set; } = null!;

        public virtual ICollection<Arac> Aracs { get; set; }
    }
}
