using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DinamikRaporJoin
    {
        public DinamikRaporJoin()
        {
            DinamikRaporKolons = new HashSet<DinamikRaporKolon>();
        }

        public int Id { get; set; }
        public int RaporTip { get; set; }
        public string JoinTablo { get; set; } = null!;
        public string JoinTabloGorunenIsim { get; set; } = null!;
        public string JoinKolon { get; set; } = null!;
        public string JoinTip { get; set; } = null!;
        public string JoinTag { get; set; } = null!;
        public bool JoinDurum { get; set; }
        public int JoinSeviye { get; set; }
        public string JoinAnaTabloKolon { get; set; } = null!;

        public virtual ICollection<DinamikRaporKolon> DinamikRaporKolons { get; set; }
    }
}
