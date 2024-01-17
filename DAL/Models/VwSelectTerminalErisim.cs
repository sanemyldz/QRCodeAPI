using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectTerminalErisim
    {
        public int Id { get; set; }
        public int IlId { get; set; }
        public DateTime? SonErisim { get; set; }
        public int Erisim { get; set; }
        public string? IlHaritaKod { get; set; }
        public int TerminalId { get; set; }
        public string Name { get; set; } = null!;
        public int HaritaId { get; set; }
        public int KurulusId { get; set; }
    }
}
