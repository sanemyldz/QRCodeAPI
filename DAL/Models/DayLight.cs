using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DayLight
    {
        public DateTime ChangeTimeS { get; set; }
        public DateTime ChangeTimeE { get; set; }
        public DateTime RestoreTimeS { get; set; }
        public DateTime RestoreTimeE { get; set; }
    }
}
