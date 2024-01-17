using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSaatlikIzinBakiye
    {
        public TblSaatlikIzinBakiye()
        {
            TblSaatlikIzinAsimSures = new HashSet<TblSaatlikIzinAsimSure>();
        }

        public int Id { get; set; }
        public int? SicilId { get; set; }
        public int? IzinId { get; set; }
        public int? IzinTipId { get; set; }
        public int? Bakiye { get; set; }
        public DateTime? SonGuncelleme { get; set; }

        public virtual ICollection<TblSaatlikIzinAsimSure> TblSaatlikIzinAsimSures { get; set; }
    }
}
