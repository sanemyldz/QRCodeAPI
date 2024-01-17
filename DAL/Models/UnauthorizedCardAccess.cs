using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UnauthorizedCardAccess
    {
        public int Id { get; set; }
        public int? OriginalId { get; set; }
        public string? CardNumber { get; set; }
        public DateTime? EventTime { get; set; }
        public int? SicilId { get; set; }
        public string? UserId { get; set; }
        public int? TerminalId { get; set; }
    }
}
