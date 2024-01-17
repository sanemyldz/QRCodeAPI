using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DutyOther
    {
        public int Id { get; set; }
        public string ProcessCode { get; set; } = null!;
        public DateTime RecordDate { get; set; }
        public DateTime? ProcessDate { get; set; }
        public string? Status { get; set; }
    }
}
