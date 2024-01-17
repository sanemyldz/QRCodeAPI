using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilIzinDetail
    {
        public TblSicilIzinDetail()
        {
            TblSicilIzinMasters = new HashSet<TblSicilIzinMaster>();
        }

        public int Id { get; set; }
        public int IzinId { get; set; }
        public int TasnifId { get; set; }
        public int IzinTipId { get; set; }
        public int Sure { get; set; }

        public virtual ICollection<TblSicilIzinMaster> TblSicilIzinMasters { get; set; }
    }
}
