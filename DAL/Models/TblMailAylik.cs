using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblMailAylik
    {
        public int Id { get; set; }
        public int? GunIndexAy { get; set; }
        public int? Ay { get; set; }
        public DateTime? SonrakiAyTarih { get; set; }
        public DateTime? AylikSonMailAtmaTarih { get; set; }
    }
}
