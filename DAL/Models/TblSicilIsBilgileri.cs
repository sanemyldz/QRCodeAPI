using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilIsBilgileri
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string? Sskno { get; set; }
        public int? GorevKurumu { get; set; }
        public int? Bolge { get; set; }
        public int? Birimi { get; set; }
        public int? Gorevi { get; set; }
        public decimal AylikNetUcret { get; set; }
        public decimal AylikBrutUcret { get; set; }
        public DateTime IsBaslangicTarihi { get; set; }
        public DateTime IseBasvuruTarih { get; set; }
        public string? IsBasvuruDurumu { get; set; }
        public DateTime? AyrilmaTarih { get; set; }
        public string? AyrilmaNedeni { get; set; }
        public decimal NetKidemTazminat { get; set; }
        public decimal NetIhbarTazminat { get; set; }
        public decimal KullanmadigiYillikIzinTutari { get; set; }
        public string? UcretTip { get; set; }
        public string? SozlesmeTur { get; set; }
    }
}
