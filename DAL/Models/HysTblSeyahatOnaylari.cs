using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HysTblSeyahatOnaylari
    {
        public int Id { get; set; }
        public int IstekId { get; set; }
        public int Onayci { get; set; }
        public int Sira { get; set; }
        public bool Onay { get; set; }
        public DateTime? OnayZamani { get; set; }

        public virtual HysTblSeyahatIstekleri Istek { get; set; } = null!;
        public virtual HysTblKullanicilar OnayciNavigation { get; set; } = null!;
    }
}
