using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilAdre
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string? Adres { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Semt { get; set; }
        public string? EvMulkiyet { get; set; }
        public string? EvTelefon { get; set; }
        public string? IsTelefon { get; set; }
        public string? CepTelefon { get; set; }
        public string? Email { get; set; }
    }
}
