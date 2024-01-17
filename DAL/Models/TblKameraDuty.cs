using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblKameraDuty
    {
        public int Id { get; set; }
        public int? PoolId { get; set; }
        public int? KameraId { get; set; }
        public int? TerminalId { get; set; }
        public DateTime? RecordDate { get; set; }
        public DateTime? ProcessedDate { get; set; }
    }
}
