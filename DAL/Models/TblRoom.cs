using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblRoom
    {
        public int Id { get; set; }
        public int? ContainerId { get; set; }
        public int? YatakSayisi { get; set; }
        public decimal? GunlukUcret { get; set; }
        public bool? Deleted { get; set; }
        public string? Adi { get; set; }
    }
}
