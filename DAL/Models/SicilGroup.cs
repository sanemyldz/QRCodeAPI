using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SicilGroup
    {
        public SicilGroup()
        {
            SicilGroupMembers = new HashSet<SicilGroupMember>();
        }

        public int Id { get; set; }
        public string Ad { get; set; } = null!;

        public virtual ICollection<SicilGroupMember> SicilGroupMembers { get; set; }
    }
}
