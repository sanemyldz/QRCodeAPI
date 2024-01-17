using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class JsonLog
    {
        public int Id { get; set; }
        public DateTime? Zaman { get; set; }
        public string? Json { get; set; }
    }
}
