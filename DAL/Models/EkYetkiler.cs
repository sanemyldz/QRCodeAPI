using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EkYetkiler
    {
        public int? SicilId { get; set; }
        public int? TerminalId { get; set; }
        public int? TimeZoneId { get; set; }
        public DateTime? Zaman { get; set; }
    }
}
