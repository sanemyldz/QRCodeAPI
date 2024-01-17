using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TerminalPort
    {
        public TerminalPort()
        {
            Terminallers = new HashSet<Terminaller>();
        }

        public string Port { get; set; } = null!;
        public int PortType { get; set; }
        public bool Active { get; set; }
        public int? Flag { get; set; }

        public virtual ICollection<Terminaller> Terminallers { get; set; }
    }
}
