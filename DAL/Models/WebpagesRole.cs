using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class WebpagesRole
    {
        public WebpagesRole()
        {
            Users = new HashSet<UserTable>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;

        public virtual KullaniciRolTanimlari? KullaniciRolTanimlari { get; set; }

        public virtual ICollection<UserTable> Users { get; set; }
    }
}
