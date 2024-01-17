using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ClockworkBellControl
    {
        public int Id { get; set; }
        public int TerminalId { get; set; }
        public int ClockworkBellId { get; set; }
        public int BellTimeTypeId { get; set; }
        public byte Saat { get; set; }
        public byte Dakika { get; set; }
        public byte TimeSecond { get; set; }

        public virtual SysBellTimeType BellTimeType { get; set; } = null!;
        public virtual Terminaller Terminal { get; set; } = null!;
    }
}
