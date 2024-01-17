using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MobilKomut
    {
        public int Id { get; set; }
        public string Adi { get; set; } = null!;
        public byte Yon { get; set; }
        public string? Baslik { get; set; }
        public int? Sira { get; set; }
        public int? MobilKomutGrupId { get; set; }
        public int? TerminalId { get; set; }

        public virtual MobilKomutGrup? MobilKomutGrup { get; set; }
        public virtual Terminaller? Terminal { get; set; }
    }
}
