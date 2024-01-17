using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HysTblSeyahatIstekleri
    {
        public HysTblSeyahatIstekleri()
        {
            HysTblSeyahatOnaylaris = new HashSet<HysTblSeyahatOnaylari>();
            HysTblSeyahatlers = new HashSet<HysTblSeyahatler>();
        }

        public int Id { get; set; }
        public int SicilId { get; set; }
        public string? Unvan { get; set; }
        public bool Deleted { get; set; }
        public int? IstekYapan { get; set; }
        public DateTime? TalepZamani { get; set; }
        public int? Taslak { get; set; }
        public string? RedMesaji { get; set; }
        public bool? MasrafListesiVarMi { get; set; }

        public virtual Sicil Sicil { get; set; } = null!;
        public virtual ICollection<HysTblSeyahatOnaylari> HysTblSeyahatOnaylaris { get; set; }
        public virtual ICollection<HysTblSeyahatler> HysTblSeyahatlers { get; set; }
    }
}
