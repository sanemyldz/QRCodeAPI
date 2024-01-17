using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CboIzinHakki
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Kod { get; set; }
        public string? Aciklama { get; set; }
    }
}
