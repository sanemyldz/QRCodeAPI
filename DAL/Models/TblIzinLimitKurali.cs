using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblIzinLimitKurali
    {
        public int Id { get; set; }
        public int IzinTipId { get; set; }
        public int IzinKuralId { get; set; }
        public int? LimitTipi { get; set; }
        public decimal? MinGunSayisi { get; set; }
        public decimal? MaxGunSayisi { get; set; }
        public int? MaxIzinSayisi { get; set; }
        public int? CinsiyetLimiti { get; set; }
        public bool? BirimPersonelLimit { get; set; }
        public int? MaxAyniBirimTalep { get; set; }
        public int? TalepZamanAraligi { get; set; }

        public virtual TblIzinTanimKurali IzinKural { get; set; } = null!;
        public virtual IzinTipleri IzinTip { get; set; } = null!;
    }
}
