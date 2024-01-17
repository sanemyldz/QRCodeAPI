using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwZiyaretciListesi
    {
        public string UserName { get; set; } = null!;
        public int Gorevli { get; set; }
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string? Soyad { get; set; }
        public DateTime? Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? DogumYeri { get; set; }
        public byte[]? KameraResim { get; set; }
        public string? RuhsatSeriNo { get; set; }
        public string? ZiyaretciKart { get; set; }
        public int? LokasyonId { get; set; }
        public string? LokasyonAd { get; set; }
        public string Kisi1 { get; set; } = null!;
        public string Kisi2 { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public string? KimlikNo { get; set; }
        public string? Firma { get; set; }
        public string? Plaka { get; set; }
        public string? Bilgi { get; set; }
        public string? Telefon { get; set; }
        public string? ZiyaretNedeni { get; set; }
        public string? ResimId { get; set; }
        public string UserId { get; set; } = null!;
        public string? BolumAdi { get; set; }
        public string? HesCode { get; set; }
    }
}
