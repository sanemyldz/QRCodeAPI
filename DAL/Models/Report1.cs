using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Report1
    {
        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string OutputFileName { get; set; } = null!;
        public bool CrystapReports { get; set; }
        public bool Active { get; set; }
    }
}
