using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KullaniciRolTanimlari
    {
        public int Id { get; set; }
        public int RolId { get; set; }
        public string SecilenModuller { get; set; } = null!;
        public int SicilErisimYetkisi { get; set; }

        public virtual WebpagesRole Rol { get; set; } = null!;
    }
}
