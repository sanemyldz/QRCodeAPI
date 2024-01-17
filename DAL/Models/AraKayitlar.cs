using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AraKayitlar
    {
        public int Id { get; set; }
        public long? TasnifId { get; set; }
        public DateTime? Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public int? Sure { get; set; }
        public int? Fsure { get; set; }
    }
}
