using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwTumIzinListesi
    {
        public int Id { get; set; }
        public string? Aciklama { get; set; }
        public int TipId { get; set; }
        public int? SicilId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? SicilNo { get; set; }
        public string? FirmaAdi { get; set; }
        public int? FirmaId { get; set; }
        public string? PersonelNo { get; set; }
        public decimal? Gun { get; set; }
        public int Sure { get; set; }
        public DateTime? BasTarih { get; set; }
        public DateTime? BitTarih { get; set; }
        public int? OnayDurum { get; set; }
        public string? IzinIslemDurumAdi { get; set; }
    }
}
