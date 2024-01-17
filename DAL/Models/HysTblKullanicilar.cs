using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HysTblKullanicilar
    {
        public HysTblKullanicilar()
        {
            HysTblMasrafOnaylaris = new HashSet<HysTblMasrafOnaylari>();
            HysTblOnaycilars = new HashSet<HysTblOnaycilar>();
            HysTblSeyahatOnaylaris = new HashSet<HysTblSeyahatOnaylari>();
        }

        public int Id { get; set; }
        public string KullaniciAdi { get; set; } = null!;
        public int SicilId { get; set; }
        public string? Parola { get; set; }
        public int Rol { get; set; }
        public bool Deleted { get; set; }
        public string? Email { get; set; }

        public virtual HysTblKullaniciRolleri RolNavigation { get; set; } = null!;
        public virtual Sicil Sicil { get; set; } = null!;
        public virtual ICollection<HysTblMasrafOnaylari> HysTblMasrafOnaylaris { get; set; }
        public virtual ICollection<HysTblOnaycilar> HysTblOnaycilars { get; set; }
        public virtual ICollection<HysTblSeyahatOnaylari> HysTblSeyahatOnaylaris { get; set; }
    }
}
