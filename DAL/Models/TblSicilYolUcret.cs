using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilYolUcret
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public DateTime? Tarih { get; set; }
        public byte? Yon { get; set; }
        public decimal? YolUcret { get; set; }
        public int? Adet { get; set; }
        public DateTime? BitisTarih { get; set; }
        public int? MesaiId { get; set; }
        public int? FmSinir { get; set; }
        public int? Tip { get; set; }
        public decimal? DonusYolUcret { get; set; }
    }
}
