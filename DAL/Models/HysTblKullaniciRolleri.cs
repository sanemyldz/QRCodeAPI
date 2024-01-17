using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HysTblKullaniciRolleri
    {
        public HysTblKullaniciRolleri()
        {
            HysTblKullanicilars = new HashSet<HysTblKullanicilar>();
        }

        public int Id { get; set; }
        public string? Rol { get; set; }

        public virtual ICollection<HysTblKullanicilar> HysTblKullanicilars { get; set; }
    }
}
