using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class FirmaBilgisi
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string? Unvan { get; set; }
        public string? Adres { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Semt { get; set; }
        public string? Posta { get; set; }
        public string? Telefon1 { get; set; }
        public string? Telefon2 { get; set; }
        public string? Fax { get; set; }
        public byte[]? Logo { get; set; }
        public string? Bilgi { get; set; }
    }
}
