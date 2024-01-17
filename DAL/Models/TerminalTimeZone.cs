using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TerminalTimeZone
    {
        public int Id { get; set; }
        public int TerminalId { get; set; }
        public int TerminalTimeZoneId { get; set; }
        public int BellTimeTypeId { get; set; }
        public byte Ssaat { get; set; }
        public byte Sdakika { get; set; }
        public byte Esaat { get; set; }
        public byte Edakika { get; set; }
        public int TerminalMode { get; set; }

        public virtual SysBellTimeType BellTimeType { get; set; } = null!;
        public virtual SysTerminalMode TerminalModeNavigation { get; set; } = null!;
    }
}
