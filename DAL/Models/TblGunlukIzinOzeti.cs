using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblGunlukIzinOzeti
    {
        public int Id { get; set; }
        public int IzinTipId { get; set; }
        public int TasnifId { get; set; }
        public bool Ucretli { get; set; }
        public int IzinId { get; set; }
        public int Sure { get; set; }
    }
}
