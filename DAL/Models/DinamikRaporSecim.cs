using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DinamikRaporSecim
    {
        public int Id { get; set; }
        public int RaporTanimId { get; set; }
        public int RaporKolonId { get; set; }

        public virtual DinamikRaporKolon RaporKolon { get; set; } = null!;
        public virtual DinamikRaporlar RaporTanim { get; set; } = null!;
    }
}
