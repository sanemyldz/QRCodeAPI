using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Yetki
    {
        public int Id { get; set; }
        public string? Aciklama { get; set; }
        public int? Gonder { get; set; }
        public string? AciklamaDetay { get; set; }
        public bool Deleted { get; set; }
        public bool? ZiyaretciKartYetki { get; set; }
    }
}
