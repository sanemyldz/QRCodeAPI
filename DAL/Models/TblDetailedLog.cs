using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblDetailedLog
    {
        public int Id { get; set; }
        public string? EkranAdi { get; set; }
        public string? Tablo { get; set; }
        public string? AlanAdi { get; set; }
        public string? Ed { get; set; }
        public string? Yd { get; set; }
        public int UserId { get; set; }
        public DateTime Zaman { get; set; }
        public int? IslemTipi { get; set; }
        public int? IslemRowId { get; set; }
    }
}
