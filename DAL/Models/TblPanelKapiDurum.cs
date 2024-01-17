using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblPanelKapiDurum
    {
        public int Id { get; set; }
        public int? PanelId { get; set; }
        public int? TerminalId { get; set; }
        public int? PanelPortNo { get; set; }
        public bool? Status { get; set; }
    }
}
