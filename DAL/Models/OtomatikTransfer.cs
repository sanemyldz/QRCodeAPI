using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class OtomatikTransfer
    {
        public int Id { get; set; }
        public int RefId { get; set; }
        public string ActionType { get; set; } = null!;
        public int SicilId { get; set; }
        public DateTime InsertTime { get; set; }
        public DateTime? ResultTime { get; set; }
        public int Flag { get; set; }
        public string? Statement { get; set; }
        public int TerminalGroup { get; set; }

        public virtual Sicil Sicil { get; set; } = null!;
    }
}
