using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblReCheckEventsDuty
    {
        public int Id { get; set; }
        public int PanelId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DetectedEventCount { get; set; }
        public int MinEventIndex { get; set; }
        public int MaxEventIndex { get; set; }
        public DateTime RecordDate { get; set; }
        public DateTime? ProcessDate { get; set; }
    }
}
