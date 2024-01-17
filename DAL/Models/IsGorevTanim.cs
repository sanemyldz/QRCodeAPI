using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class IsGorevTanim
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Aciklama { get; set; } = null!;
        public DateTime BaslanticTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int Olusturan { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public bool Aktif { get; set; }
        public int MobilKullaniciId { get; set; }
        public bool Deleted { get; set; }

        public virtual MobilKullanici MobilKullanici { get; set; } = null!;
    }
}
