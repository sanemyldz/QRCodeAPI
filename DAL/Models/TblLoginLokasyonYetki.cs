using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblLoginLokasyonYetki
    {
        public int Id { get; set; }
        public int? LokasyonId { get; set; }
        public int? LoginId { get; set; }
    }
}
