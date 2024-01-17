using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblAcEtkin
    {
        public int Id { get; set; }
        public bool? Acetkin { get; set; }
        public string? DomainName { get; set; }
        public string? DomainPath { get; set; }
    }
}
