using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectIzinAkisDetay
    {
        public int Id { get; set; }
        public int AkisId { get; set; }
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public int? SiraNo { get; set; }
        public string? Aciklama { get; set; }
        public int? OnaySayi { get; set; }
    }
}
