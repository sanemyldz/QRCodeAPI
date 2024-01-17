using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAaIlkGirisSonCiki
    {
        public string? SicilNo { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? Giris { get; set; }
        public DateTime? Cikis { get; set; }
    }
}
