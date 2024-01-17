using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwUygunKartlar
    {
        public string UserId { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int? Gorev { get; set; }
    }
}
