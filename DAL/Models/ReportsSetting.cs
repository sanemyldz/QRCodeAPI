using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ReportsSetting
    {
        public int Id { get; set; }
        public string Kod { get; set; } = null!;
        public bool? Header { get; set; }
        public int? GroupFieldId { get; set; }
        public bool? DailyTotal { get; set; }
        public bool? WeeklyTotal { get; set; }
        public bool? MonthlyTotal { get; set; }
        public string? EmailIntroText { get; set; }
        public bool? EmailContent { get; set; }
        public bool? EmailAttach { get; set; }
    }
}
