using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSonTerminalSokulmeIslemi
    {
        public int Id { get; set; }
        public int? TerminalId { get; set; }
        public DateTime? CihazSonIslemZamani { get; set; }
        public string? CihazSokulmeDurum { get; set; }
        public bool? CihazSokuldu { get; set; }
    }
}
