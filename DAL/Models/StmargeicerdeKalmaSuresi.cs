using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class StmargeicerdeKalmaSuresi
    {
        public int SicilId { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public int? Fark { get; set; }
        public int? Yil { get; set; }
        public int? Ay { get; set; }
        public int? Gun { get; set; }
        public int? Hafta { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
    }
}
