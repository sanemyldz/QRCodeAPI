using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserListIndex
    {
        public int Id { get; set; }
        public int TerminalId { get; set; }
        public string UserId { get; set; } = null!;
        public int Index { get; set; }
        public int UserLevel { get; set; }
        public int Option1 { get; set; }
        public int Option2 { get; set; }
        public int AccessType { get; set; }
        public int TimeZoneNo1 { get; set; }
        public int TimeZoneNo2 { get; set; }
        public bool? UserMode { get; set; }
        public int TimedAntiPassback { get; set; }
        public int AuthLimitCount { get; set; }
        public string? Devicemessage2 { get; set; }
        public string? Devicemessage21 { get; set; }

        public virtual Terminaller Terminal { get; set; } = null!;
    }
}
