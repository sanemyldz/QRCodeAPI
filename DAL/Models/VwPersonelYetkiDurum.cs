using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwPersonelYetkiDurum
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int IlaveYetkiId { get; set; }
        public int TerminalId { get; set; }
        public string? TerminalAdi { get; set; }
        public string? YetkiAdi { get; set; }
        public int? YetkiDurumu { get; set; }
    }
}
