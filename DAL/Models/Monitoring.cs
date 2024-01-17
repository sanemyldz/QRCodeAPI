using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Monitoring
    {
        public int Id { get; set; }
        public int? TerminalId { get; set; }
        public DateTime? Eventtime { get; set; }
        public int? SicilId { get; set; }
        public string? UserId { get; set; }
        public string? GateIomessage { get; set; }
        public string? EventCode { get; set; }
        public string? Description { get; set; }
        public int? EventIndex { get; set; }
        public int? DinamikLokasyonId { get; set; }
    }
}
