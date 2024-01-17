using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblKameraTerminal
    {
        public int Id { get; set; }
        public int? KameraId { get; set; }
        public int? TerminalId { get; set; }
    }
}
