using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HysTblMasrafTalepleri
    {
        public HysTblMasrafTalepleri()
        {
            HysTblMasrafOnaylaris = new HashSet<HysTblMasrafOnaylari>();
            HysTblMasraflars = new HashSet<HysTblMasraflar>();
        }

        public int Id { get; set; }
        public int SicilId { get; set; }
        public string Unvan { get; set; } = null!;
        public int IstekYapan { get; set; }
        public bool Deleted { get; set; }
        public DateTime? TalepZamani { get; set; }
        public bool? Taslak { get; set; }
        public int? FilesCount { get; set; }
        public string? RedMesaji { get; set; }
        public int? SeyahatId { get; set; }

        public virtual Sicil Sicil { get; set; } = null!;
        public virtual ICollection<HysTblMasrafOnaylari> HysTblMasrafOnaylaris { get; set; }
        public virtual ICollection<HysTblMasraflar> HysTblMasraflars { get; set; }
    }
}
