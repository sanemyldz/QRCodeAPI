using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Fotograf
    {
        public int Id { get; set; }
        public int? TermiinalId { get; set; }
        public int? PoolId { get; set; }
        public int? SicilId { get; set; }
        public DateTime? EventTime { get; set; }
        public string? DosyaYol { get; set; }
    }
}
