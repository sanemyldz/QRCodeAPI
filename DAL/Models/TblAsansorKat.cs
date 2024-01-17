using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblAsansorKat
    {
        public int Id { get; set; }
        public int? AsansorId { get; set; }
        public int? SiraNo { get; set; }
        public string? KatEtiket { get; set; }
    }
}
