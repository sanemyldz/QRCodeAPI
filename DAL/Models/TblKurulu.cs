using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblKurulu
    {
        public int Id { get; set; }
        public string? KurulusAdi { get; set; }
        public int? IlId { get; set; }
    }
}
