using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblPanelAsansor
    {
        public int Id { get; set; }
        public int? PanelId { get; set; }
        public int? TerminalId { get; set; }
        public int? AsansorId { get; set; }
        public int? PortNumber { get; set; }
    }
}
