using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblIzinKidemKurali
    {
        public int Id { get; set; }
        public int IzinKuralId { get; set; }
        public int IzinTipId { get; set; }
        public int MinKidemYili { get; set; }
        public int MaxKidemYili { get; set; }
        public int HakEdilenGun { get; set; }
        public int TalepTipId { get; set; }

        public virtual TblIzinTanimKurali IzinKural { get; set; } = null!;
        public virtual IzinTipleri IzinTip { get; set; } = null!;
    }
}
