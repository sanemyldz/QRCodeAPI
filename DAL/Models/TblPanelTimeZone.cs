using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblPanelTimeZone
    {
        public int Id { get; set; }
        public string? TimeZoneName { get; set; }
        public bool? Gonderildi { get; set; }
        public DateTime? GonderimZamani { get; set; }
        public bool? Deleted { get; set; }
    }
}
