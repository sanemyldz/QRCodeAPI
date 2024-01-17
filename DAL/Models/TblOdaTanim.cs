using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblOdaTanim
    {
        public int Id { get; set; }
        public string? OdaAdi { get; set; }
        public int? RaporTolerans { get; set; }
    }
}
