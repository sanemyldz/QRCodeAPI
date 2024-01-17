using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblLoginYetkiGrubu
    {
        public int Id { get; set; }
        public int LoginId { get; set; }
        public int GrupYetki { get; set; }
    }
}
