using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KrediTakip
    {
        public string? SicilId { get; set; }
        public string? UserId { get; set; }
        public string? Islem { get; set; }
        public string? Tutar { get; set; }
        public DateTime? Tarih { get; set; }
        public int? TerminalId { get; set; }
    }
}
