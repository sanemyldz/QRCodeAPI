using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblPanelUsersTimeZone
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public int SicilId { get; set; }
        public int TimeZoneId { get; set; }
        public int TerminalId { get; set; }
        public int PanelId { get; set; }
    }
}
