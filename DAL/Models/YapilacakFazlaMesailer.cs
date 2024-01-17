using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class YapilacakFazlaMesailer
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public string? Aciklama { get; set; }
        public bool? Deleted { get; set; }
        public int? OnayDurum { get; set; }
        public DateTime? TalepTarihi { get; set; }
        public int? AnlikSira { get; set; }
        public int? UserId { get; set; }
        public int? SebepId { get; set; }
        public int DinlenmeSure { get; set; }
    }
}
