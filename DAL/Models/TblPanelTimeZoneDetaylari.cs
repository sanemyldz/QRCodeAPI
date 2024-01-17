using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblPanelTimeZoneDetaylari
    {
        public int Id { get; set; }
        public int TimeZoneId { get; set; }
        public int GunIndex { get; set; }
        public int TimeZoneIndex { get; set; }
        public int? BasSaat { get; set; }
        public int? SonSaat { get; set; }
    }
}
