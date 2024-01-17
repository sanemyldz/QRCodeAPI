using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HysTblMasrafOnaylari
    {
        public int Id { get; set; }
        public int TalepId { get; set; }
        public int Onayci { get; set; }
        public int Sira { get; set; }
        public bool Onay { get; set; }
        public DateTime? OnayZamani { get; set; }

        public virtual HysTblKullanicilar OnayciNavigation { get; set; } = null!;
        public virtual HysTblMasrafTalepleri Talep { get; set; } = null!;
    }
}
