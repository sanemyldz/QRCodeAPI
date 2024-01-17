using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DinamikRaporKolon
    {
        public DinamikRaporKolon()
        {
            DinamikRaporSecims = new HashSet<DinamikRaporSecim>();
        }

        public int Id { get; set; }
        public int JoinId { get; set; }
        public int RaporTip { get; set; }
        public string KolonAd { get; set; } = null!;
        public string GorunenAd { get; set; } = null!;
        public bool? Grupla { get; set; }

        public virtual DinamikRaporJoin Join { get; set; } = null!;
        public virtual DinamikRaporTip RaporTipNavigation { get; set; } = null!;
        public virtual ICollection<DinamikRaporSecim> DinamikRaporSecims { get; set; }
    }
}
