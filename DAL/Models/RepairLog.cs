using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class RepairLog
    {
        public int Id { get; set; }
        public string? Islem { get; set; }
        public DateTime? Zaman { get; set; }
    }
}
