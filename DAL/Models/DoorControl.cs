using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DoorControl
    {
        public int Id { get; set; }
        public DateTime? Acildi { get; set; }
        public DateTime? Kapandi { get; set; }
        public int? TerminalId { get; set; }
        public int? Sure { get; set; }
    }
}
