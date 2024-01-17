using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblHesaplayiciZaman
    {
        public int Id { get; set; }
        public DateTime? BaslangicZamani { get; set; }
        public DateTime? BitisZamani { get; set; }
        public int? Durum { get; set; }
        public int? SonPoolId { get; set; }
    }
}
