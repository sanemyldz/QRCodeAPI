using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblFizin
    {
        public int Id { get; set; }
        public string SicilId { get; set; } = null!;
        public DateTime MesaiTarih { get; set; }
        public int? F1 { get; set; }
        public int? F2 { get; set; }
        public int? F3 { get; set; }
        public int? F4 { get; set; }
        public int? DigerIzinler { get; set; }
    }
}
