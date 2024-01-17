using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSysReport
    {
        public int Id { get; set; }
        public string RaporAdi { get; set; } = null!;
        public string RaporKodu { get; set; } = null!;
        public string RaporModulu { get; set; } = null!;
        public bool Aktif { get; set; }
        public string? RptFile { get; set; }
        public string? PartialView { get; set; }
        public string? Method { get; set; }
    }
}
