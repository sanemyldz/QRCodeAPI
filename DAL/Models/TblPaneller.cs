using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblPaneller
    {
        public int Id { get; set; }
        public string PanelName { get; set; } = null!;
        public string PanelIp { get; set; } = null!;
        public int? PanelPort { get; set; }
        public int Port1 { get; set; }
        public int Port2 { get; set; }
        public int Port3 { get; set; }
        public int Port4 { get; set; }
        public bool? Aktif { get; set; }
        public int? SonUserIndex { get; set; }
        public int? ReadIndex { get; set; }
        public int? WriteIndex { get; set; }
        public int? UnreadIndex { get; set; }
        public int? LastSavedEventIndex { get; set; }
        public int? PanelTip { get; set; }
    }
}
