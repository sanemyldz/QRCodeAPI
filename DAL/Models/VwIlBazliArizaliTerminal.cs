using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwIlBazliArizaliTerminal
    {
        public int Id { get; set; }
        public string? IlHaritaKod { get; set; }
        public int? ErisimToplam { get; set; }
        public int? TerminalSayisi { get; set; }
    }
}
