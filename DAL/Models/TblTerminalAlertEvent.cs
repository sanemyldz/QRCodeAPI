using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblTerminalAlertEvent
    {
        public int Id { get; set; }
        public int TerminalId { get; set; }
        public int PanelId { get; set; }
        public DateTime Eventtime { get; set; }
        public string? EventName { get; set; }
        public string? UserId { get; set; }
    }
}
