using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HysTblOnaySurecleri
    {
        public HysTblOnaySurecleri()
        {
            HysTblKullaniciyaAtananSureclerSurec0s = new HashSet<HysTblKullaniciyaAtananSurecler>();
            HysTblKullaniciyaAtananSureclerSurec1s = new HashSet<HysTblKullaniciyaAtananSurecler>();
            HysTblOnaycilars = new HashSet<HysTblOnaycilar>();
        }

        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public bool Deleted { get; set; }

        public virtual ICollection<HysTblKullaniciyaAtananSurecler> HysTblKullaniciyaAtananSureclerSurec0s { get; set; }
        public virtual ICollection<HysTblKullaniciyaAtananSurecler> HysTblKullaniciyaAtananSureclerSurec1s { get; set; }
        public virtual ICollection<HysTblOnaycilar> HysTblOnaycilars { get; set; }
    }
}
