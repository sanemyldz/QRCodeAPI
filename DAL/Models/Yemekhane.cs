using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Yemekhane
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public DateTime? Tarih { get; set; }
        public int? Kredi { get; set; }
        public int? EkKredi { get; set; }
        public int Kredi1 { get; set; }
        public int TerminalId { get; set; }

        public virtual Sicil Sicil { get; set; } = null!;
    }
}
