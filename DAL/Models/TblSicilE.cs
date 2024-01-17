using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilE
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public string? KimlikSeri { get; set; }
        public string? KimlikNo { get; set; }
        public string? TckimlikNo { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public bool? CalismaDurumu { get; set; }
        public string? CalistigiKurum { get; set; }
        public string? IsTelefonu { get; set; }
        public string? CepTelefonu { get; set; }
        public string? Email { get; set; }
    }
}
