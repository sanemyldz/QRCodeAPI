using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblKameraEvent
    {
        public int Id { get; set; }
        public int? KameraId { get; set; }
        public int? TerminalId { get; set; }
        public int? PoolId { get; set; }
        public string? ResimYolu { get; set; }
        public DateTime? EventTime { get; set; }
    }
}
