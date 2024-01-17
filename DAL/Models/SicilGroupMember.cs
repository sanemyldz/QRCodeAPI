using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SicilGroupMember
    {
        public int Id { get; set; }
        public int SicilGroupId { get; set; }
        public int SicilId { get; set; }

        public virtual Sicil Sicil { get; set; } = null!;
        public virtual SicilGroup SicilGroup { get; set; } = null!;
    }
}
