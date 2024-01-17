using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSysYetkiKey
    {
        public int Id { get; set; }
        public string? YetkiAdi { get; set; }
        public int? TimeZoneId { get; set; }
    }
}
