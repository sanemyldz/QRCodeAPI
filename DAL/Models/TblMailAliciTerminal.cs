using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblMailAliciTerminal
    {
        public int Id { get; set; }
        public int TerminalId { get; set; }
        public int MailId { get; set; }
    }
}
