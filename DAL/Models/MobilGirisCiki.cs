using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MobilGirisCiki
    {
        public int Id { get; set; }
        public string MobilKomutAdi { get; set; } = null!;
        public string AdSoyad { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public DateTime GirisZamani { get; set; }
        public DateTime CikisZamani { get; set; }
        public string? GrupAdi { get; set; }
    }
}
