using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblEventKey
    {
        public int Id { get; set; }
        public int? EventCode { get; set; }
        public string? Event { get; set; }
    }
}
