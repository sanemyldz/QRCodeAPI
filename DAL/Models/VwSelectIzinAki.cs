using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectIzinAki
    {
        public int Id { get; set; }
        public int AkisId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string AkisAdi { get; set; } = null!;
        public int SiraNo { get; set; }
    }
}
