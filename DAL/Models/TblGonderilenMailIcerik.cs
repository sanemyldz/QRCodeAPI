using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblGonderilenMailIcerik
    {
        public int Id { get; set; }
        public string? MailIcerik { get; set; }
        public string? MailAdres { get; set; }
        public DateTime? GondermeTarihi { get; set; }
        public string? RaporAdi { get; set; }
    }
}
