using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TerminalAcu121
    {
        public int Id { get; set; }
        public int TerminalId { get; set; }
        public string UserId { get; set; } = null!;
        public int Index { get; set; }

        public virtual Terminaller Terminal { get; set; } = null!;
    }
}
