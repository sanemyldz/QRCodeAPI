using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TerminalYetkiDurum
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int TerminalId { get; set; }
        public string TerminalAdi { get; set; } = null!;
        public string YetkiDurum { get; set; } = null!;
        public string YetkiAdi { get; set; } = null!;
        public int YetkiRowId { get; set; }
    }
}
