using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSaatlikIzinAsimSure
    {
        public int Id { get; set; }
        public int? AsilanSure { get; set; }
        public int? SaatlikIzinBakiyeId { get; set; }
        public DateTime? SonGuncelleme { get; set; }
        public int? IzinTipId { get; set; }

        public virtual TblSaatlikIzinBakiye? SaatlikIzinBakiye { get; set; }
    }
}
