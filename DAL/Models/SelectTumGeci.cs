using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SelectTumGeci
    {
        public string? UrunGrubu { get; set; }
        public string? Description { get; set; }
        public int Id { get; set; }
        public DateTime? Eventtime { get; set; }
        public string? EventCode { get; set; }
        public string? Event { get; set; }
        public string? UserId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string Name { get; set; } = null!;
        public string? Lokasyon { get; set; }
    }
}
