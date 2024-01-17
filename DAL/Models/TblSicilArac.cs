using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilArac
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int AracSicilId { get; set; }
        public string AracPlaka { get; set; } = null!;
        public string? RuhsatNo { get; set; }
        public string? Aciklama { get; set; }
        public string? CepTelefonu { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? Marka { get; set; }
        public string? Model { get; set; }
    }
}
