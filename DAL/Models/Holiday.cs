using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Holiday
    {
        public int Id { get; set; }
        public string HolidayName { get; set; } = null!;
        public int MonthId { get; set; }
        public int DayId { get; set; }
    }
}
