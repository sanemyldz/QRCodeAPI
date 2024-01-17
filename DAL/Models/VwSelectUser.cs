using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string RoleName { get; set; } = null!;
        public int RoleId { get; set; }
    }
}
