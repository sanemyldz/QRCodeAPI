using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilIzinMaster
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public int? TasnifId { get; set; }
        public DateTime? MesaiTarihi { get; set; }
        public int? ToplamIzinSayisi { get; set; }
        public int? IzinDetailId { get; set; }
        public int? ToplamSure { get; set; }

        public virtual TblSicilIzinDetail? IzinDetail { get; set; }
        public virtual Sicil? Sicil { get; set; }
    }
}
