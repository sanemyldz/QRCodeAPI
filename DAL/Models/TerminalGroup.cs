using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TerminalGroup
    {
        public TerminalGroup()
        {
            Sicils = new HashSet<Sicil>();
            TerminalRelations = new HashSet<TerminalRelation>();
        }

        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public int? Alarm { get; set; }
        public DateTime? Lastaccounted { get; set; }

        public virtual ICollection<Sicil> Sicils { get; set; }
        public virtual ICollection<TerminalRelation> TerminalRelations { get; set; }
    }
}
