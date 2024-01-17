using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblVardiyasizMesaiOzeti
    {
        public int Id { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public int? SicilId { get; set; }
        public DateTime? Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public int? CurrentBirimId { get; set; }
    }
}
