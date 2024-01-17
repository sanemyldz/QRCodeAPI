using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TerminalRelation
    {
        public int Id { get; set; }
        public int TerminalGrubu { get; set; }
        public int Terminal { get; set; }

        public virtual TerminalGroup TerminalGrubuNavigation { get; set; } = null!;
        public virtual Terminaller TerminalNavigation { get; set; } = null!;
    }
}
