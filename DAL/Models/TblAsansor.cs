using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblAsansor
    {
        public int Id { get; set; }
        public string? Adi { get; set; }
        public int? KatSayisi { get; set; }
        public bool? Deleted { get; set; }
    }
}
