using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CboOzlukOkul
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public int? EgitimDuzey { get; set; }
    }
}
