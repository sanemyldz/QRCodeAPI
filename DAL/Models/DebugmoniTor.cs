using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DebugmoniTor
    {
        public int Id { get; set; }
        public string Message { get; set; } = null!;
        public DateTime TiMe { get; set; }
    }
}
