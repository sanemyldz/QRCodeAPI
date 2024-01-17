using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Access
    {
        public int Id { get; set; }
        public int? TargetDevice { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string? UserId { get; set; }
        public string? Owner { get; set; }
        public DateTime? RecordDate { get; set; }
        public DateTime? ProcessDate { get; set; }
    }
}
