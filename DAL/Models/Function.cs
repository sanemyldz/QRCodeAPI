using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Function
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string? Aciklama { get; set; }
    }
}
