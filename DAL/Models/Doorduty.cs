using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Doorduty
    {
        public int Id { get; set; }
        public string? Port { get; set; }
        public string? Controllerno { get; set; }
        public DateTime? RecordDate { get; set; }
        public DateTime? ProcessDate { get; set; }
        public long? Time { get; set; }
    }
}
