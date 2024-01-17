using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSonBaglantiDurum
    {
        public int Id { get; set; }
        public int? TerminalId { get; set; }
        public string? SonBaglantiOlayi { get; set; }
        public DateTime? SonBaglantiZamani { get; set; }
        public bool? CihazBagli { get; set; }
    }
}
