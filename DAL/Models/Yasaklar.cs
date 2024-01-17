using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Yasaklar
    {
        public int Id { get; set; }
        public int? Suresiz { get; set; }
        public DateTime? Baslangic { get; set; }
        public string? Aciklama { get; set; }
        public int? SicilId { get; set; }
        public DateTime? Bitis { get; set; }
        public int Aktif { get; set; }
    }
}
