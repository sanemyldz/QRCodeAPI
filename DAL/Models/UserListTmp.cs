using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserListTmp
    {
        public int Id { get; set; }
        public string TmpUserId { get; set; } = null!;
        public int SicilId { get; set; }
        public string UserId { get; set; } = null!;

        public virtual Sicil Sicil { get; set; } = null!;
    }
}
