using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PersonelBilgileri
    {
        public string SicilNo { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string CardId { get; set; } = null!;
        public string? OrganizasyonKodu { get; set; }
        public string? PozisyonKodu { get; set; }
        public string? GorevKodu { get; set; }
        public string? SirketKodu { get; set; }
        public string? PersonelAlani { get; set; }
        public string? PersonelAltAlani { get; set; }
        public string? CalisanGrubu { get; set; }
        public string? CalisanAltGrubu { get; set; }
        public string IseGirisTarihi { get; set; } = null!;
        public string? IstenCikisTarihi { get; set; }
        public string IstihdamDurumu { get; set; } = null!;
        public string? YetkiGrubuAdi { get; set; }
    }
}
