using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblPanelTimezoneDuty
    {
        public int Id { get; set; }
        public int TimezoneId { get; set; }
        public int PanelId { get; set; }
        public DateTime OlusturmaZamani { get; set; }
        public DateTime? GonderimeZamani { get; set; }
    }
}
