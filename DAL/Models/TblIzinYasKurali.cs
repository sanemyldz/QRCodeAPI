using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblIzinYasKurali
    {
        public int Id { get; set; }
        public int IzinKuralId { get; set; }
        public int IzinTipId { get; set; }
        public int MinYas { get; set; }
        public int MaxYas { get; set; }
        public int HakEdilenGun { get; set; }

        public virtual TblIzinTanimKurali IzinKural { get; set; } = null!;
        public virtual IzinTipleri IzinTip { get; set; } = null!;
    }
}
