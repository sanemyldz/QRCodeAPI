using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblOzlukVekalet
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public int? VekaletEdilenSicilId { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public string? Aciklama { get; set; }
    }
}
