using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TerminalFonksiyon
    {
        public int Id { get; set; }
        public int FonksiyonId { get; set; }
        public string? FonksiyonName { get; set; }
    }
}
