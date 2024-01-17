using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HbysAktarim
    {
        public string? PersonelNo { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public DateTime? MesaiBaslangic { get; set; }
        public DateTime? MesaiBitis { get; set; }
        public string? ToplamCalisma { get; set; }
    }
}
