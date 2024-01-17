using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AnketTamamlanan
    {
        public int Id { get; set; }
        public int? AnketId { get; set; }
        public int? SicilId { get; set; }
        public DateTime? Zaman { get; set; }
    }
}
