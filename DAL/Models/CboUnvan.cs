using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CboUnvan
    {
        public int Id { get; set; }
        public string Adi { get; set; } = null!;
        public string? Kodu { get; set; }
    }
}
