using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class GorevlendirmeTipler
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Kod { get; set; } = null!;
        public bool Deleted { get; set; }
    }
}
