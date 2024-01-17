using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilIlceler
    {
        public int IlceNo { get; set; }
        public string? Isim { get; set; }
        public int IlNo { get; set; }

        public virtual TblSicilIller IlNoNavigation { get; set; } = null!;
    }
}
