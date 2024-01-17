using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSysGateIoEventName
    {
        public int Id { get; set; }
        public string? EnEventName { get; set; }
        public string? TrEventName { get; set; }
    }
}
