using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblLedPanel
    {
        public int Id { get; set; }
        public string? LedPanelAdi { get; set; }
        public string? LedPanelIp { get; set; }
        public int TerminalId { get; set; }
        public string? HosgeldinMesaji { get; set; }
        public int? UserId { get; set; }
        public DateTime? Islemdate { get; set; }

        public virtual Terminaller Terminal { get; set; } = null!;
    }
}
