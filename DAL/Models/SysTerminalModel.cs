using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysTerminalModel
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public int? Port { get; set; }
    }
}
