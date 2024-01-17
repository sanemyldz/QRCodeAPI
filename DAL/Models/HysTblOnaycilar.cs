using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HysTblOnaycilar
    {
        public int Id { get; set; }
        public int SurecId { get; set; }
        public int KullaniciId { get; set; }
        public int Sira { get; set; }

        public virtual HysTblKullanicilar Kullanici { get; set; } = null!;
        public virtual HysTblOnaySurecleri Surec { get; set; } = null!;
    }
}
