using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblOgunSayilari
    {
        public int Id { get; set; }
        public int? OgunId { get; set; }
        public DateTime? Tarih { get; set; }
        public int? Sayi { get; set; }
        public int? FirmaId { get; set; }
    }
}
