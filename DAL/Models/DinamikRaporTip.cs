using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DinamikRaporTip
    {
        public DinamikRaporTip()
        {
            DinamikRaporKolons = new HashSet<DinamikRaporKolon>();
            DinamikRaporlars = new HashSet<DinamikRaporlar>();
        }

        public int Id { get; set; }
        public string RaporTip { get; set; } = null!;

        public virtual ICollection<DinamikRaporKolon> DinamikRaporKolons { get; set; }
        public virtual ICollection<DinamikRaporlar> DinamikRaporlars { get; set; }
    }
}
