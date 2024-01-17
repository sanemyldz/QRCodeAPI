using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSysProcess
    {
        public int Id { get; set; }
        public string? ProcessNo { get; set; }
        public string? ProcessName { get; set; }
    }
}
