using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwTest
    {
        public int Id { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public int? SicilId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public int? TotalIceridekiSure { get; set; }
        public int? BirimId { get; set; }
    }
}
