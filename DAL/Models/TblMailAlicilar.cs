using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblMailAlicilar
    {
        public int Id { get; set; }
        public string? MailAdresi { get; set; }
        public int? FirmaId { get; set; }
        public int? BolumId { get; set; }
        public int? BirimId { get; set; }
        public bool? Aktif { get; set; }
        public int? YetkiId { get; set; }
        public int SicilId { get; set; }
        public int? TerminalId { get; set; }
    }
}
