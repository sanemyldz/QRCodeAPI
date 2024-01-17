using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblLoginRaporYetki
    {
        public int Id { get; set; }
        public int? RaporId { get; set; }
        public int? LoginId { get; set; }
    }
}
