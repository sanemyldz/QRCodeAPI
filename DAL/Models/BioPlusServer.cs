using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class BioPlusServer
    {
        public int? TerminalId { get; set; }
        public DateTime? StatusTime { get; set; }
        public int? Status { get; set; }
    }
}
