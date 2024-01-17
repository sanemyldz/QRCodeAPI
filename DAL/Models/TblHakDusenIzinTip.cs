using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblHakDusenIzinTip
    {
        public int Id { get; set; }
        public int IzinTanimKuralId { get; set; }
        public int IzinTipId { get; set; }
    }
}
