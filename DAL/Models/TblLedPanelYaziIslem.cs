using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblLedPanelYaziIslem
    {
        public int Id { get; set; }
        public int TerminalId { get; set; }
        public bool YaziGonderildi { get; set; }
    }
}
