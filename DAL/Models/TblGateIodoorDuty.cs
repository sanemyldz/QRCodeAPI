using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblGateIodoorDuty
    {
        public int Id { get; set; }
        public string PanelIp { get; set; } = null!;
        public int PortNo { get; set; }
        public int TerminalId { get; set; }
        public string ProcessCode { get; set; } = null!;
        public DateTime RecordDate { get; set; }
        public DateTime? ProcessDate { get; set; }
    }
}
