using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UrunSipari
    {
        public UrunSipari()
        {
            UrunSiparisDetays = new HashSet<UrunSiparisDetay>();
        }

        public int Id { get; set; }
        public int? SicilId { get; set; }
        public DateTime? Zaman { get; set; }

        public virtual Sicil? Sicil { get; set; }
        public virtual ICollection<UrunSiparisDetay> UrunSiparisDetays { get; set; }
    }
}
