using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CompanyInfo
    {
        public string Kod { get; set; } = null!;
        public string Unvan { get; set; } = null!;
        public string? Adres { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? PostaKodu { get; set; }
        public string? Telefon1 { get; set; }
        public string? Telefon2 { get; set; }
        public string? Fax { get; set; }
        public string? VergiDairesi { get; set; }
        public string? VergiNo { get; set; }
        public string? Bilgi { get; set; }
        public byte[]? Logo { get; set; }
        public byte[]? Kroki { get; set; }
    }
}
