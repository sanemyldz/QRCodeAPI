using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CboSgkbilgi
    {
        public int Id { get; set; }
        public string Adi { get; set; } = null!;
        public string Kodu { get; set; } = null!;
        public string? Aciklama { get; set; }
    }
}
