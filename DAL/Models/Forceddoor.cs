using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Forceddoor
    {
        public int Id { get; set; }
        public int? TerminalId { get; set; }
        public DateTime? Eventtime { get; set; }
        public int? SicilId { get; set; }
        public int? UserId { get; set; }
        public int? EventCode { get; set; }
        public string? Description { get; set; }
    }
}
