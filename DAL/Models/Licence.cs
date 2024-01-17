using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Licence
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public int Type { get; set; }
    }
}
