using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DinamikRaporlar
    {
        public DinamikRaporlar()
        {
            DinamikRaporSecims = new HashSet<DinamikRaporSecim>();
        }

        public int Id { get; set; }
        public int RaporTip { get; set; }
        public string RaporAdi { get; set; } = null!;
        public string Olusturan { get; set; } = null!;
        public DateTime OlusturmaTarihi { get; set; }
        public bool? Deleted { get; set; }
        public int? GrupKolonId { get; set; }

        public virtual DinamikRaporTip RaporTipNavigation { get; set; } = null!;
        public virtual ICollection<DinamikRaporSecim> DinamikRaporSecims { get; set; }
    }
}
