using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PersonelItiraz
    {
        public int Id { get; set; }
        public int? ItirazEden { get; set; }
        public byte? AygitTipi { get; set; }
        public string? Konu { get; set; }
        public string? Aciklama { get; set; }
        public DateTime? Tarih { get; set; }
        public byte Durum { get; set; }
        public int? Yanitlayan { get; set; }
        public string? Yanit { get; set; }
        public DateTime? YanitTarih { get; set; }
        public bool? Deleted { get; set; }
    }
}
