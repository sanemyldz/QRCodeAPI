using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblLoginTerminalYetki
    {
        public int Id { get; set; }
        public int TerminalId { get; set; }
        public int LoginId { get; set; }
    }
}
