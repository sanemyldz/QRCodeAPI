using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SablonlarDetay
    {
        public int Id { get; set; }
        public int? SablonId { get; set; }
        public string? Alan { get; set; }
    }
}
