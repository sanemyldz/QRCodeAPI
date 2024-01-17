using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblBirimler
    {
        public int Id { get; set; }
        public int? BirimKodu { get; set; }
        public string? BirimAdi { get; set; }
        public int? ParentId { get; set; }
        public int? Salon { get; set; }
        public int? Mutfak { get; set; }
        public int? Kasiyer { get; set; }
        public int? Ekstra { get; set; }
        public int? SalonId { get; set; }
        public int? MutfakId { get; set; }
        public int? KasiyerId { get; set; }
        public int? EkstraId { get; set; }
        public string? CihazId { get; set; }
        public string? CihazUstBirimId { get; set; }
        public string? EntegrasyonKod { get; set; }
    }
}
