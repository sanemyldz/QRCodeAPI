using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DeviceYetkiLog
    {
        public int Id { get; set; }
        public int? YetkiId { get; set; }
        public int? TerminalId { get; set; }
        public int? TimezoneId { get; set; }
        public int? Gonder { get; set; }
        public int TimedAntiPassbackx { get; set; }
        public int AuthLimitCountx { get; set; }
        public int LoginUserId { get; set; }
        public int IslemTipId { get; set; }
        public DateTime IslemDateTime { get; set; }
    }
}
