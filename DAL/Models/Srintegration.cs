using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Srintegration
    {
        public int Id { get; set; }
        public string Event { get; set; } = null!;
        public DateTime Time { get; set; }
        public string Data { get; set; } = null!;
        public string? Result { get; set; }
        public bool? Success { get; set; }
    }
}
