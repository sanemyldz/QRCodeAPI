using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblKameraTanim
    {
        public int Id { get; set; }
        public string KameraAdi { get; set; } = null!;
        public string KameraIp { get; set; } = null!;
        public int KameraPort { get; set; }
        public int? TerminalId { get; set; }
        public int? PanelId { get; set; }
        public string KameraUserName { get; set; } = null!;
        public string KameraPass { get; set; } = null!;
        public bool? Deleted { get; set; }
    }
}
