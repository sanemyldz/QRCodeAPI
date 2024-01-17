using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilCocuk
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? MedeniDurum { get; set; }
        public string? EgitimDurumu { get; set; }
    }
}
