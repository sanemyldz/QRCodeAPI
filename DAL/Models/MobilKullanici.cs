using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MobilKullanici
    {
        public MobilKullanici()
        {
            IsGorevTanims = new HashSet<IsGorevTanim>();
        }

        public int Id { get; set; }
        public int? SicilId { get; set; }
        public string? UserId { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? Sifre { get; set; }
        public string? Token { get; set; }
        public int? Rol { get; set; }
        public bool? Aktif { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual ICollection<IsGorevTanim> IsGorevTanims { get; set; }
    }
}
