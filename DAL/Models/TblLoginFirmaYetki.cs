using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblLoginFirmaYetki
    {
        public int Id { get; set; }
        public int? FirmaId { get; set; }
        public int? LoginId { get; set; }
    }
}
