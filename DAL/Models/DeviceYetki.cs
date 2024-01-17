using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DeviceYetki
    {
        public int Id { get; set; }
        public int? YetkiId { get; set; }
        public int? TerminalId { get; set; }
        public int? TimezoneId { get; set; }
        public int? Gonder { get; set; }
        public int TimedAntiPassbackx { get; set; }
        public int AuthLimitCountx { get; set; }
    }
}
