using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAylikDevamDetayCizelge
    {
        public int Id { get; set; }
        public string? BolumAdi { get; set; }
        public int? BolumId { get; set; }
        public int? SicilId { get; set; }
        public string? SicilNo { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public int? TasnifId { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public int? ResmiTatil { get; set; }
        public int? Tatil { get; set; }
        public string? IzinIdList { get; set; }
        public string? Aciklama { get; set; }
        public DateTime? Giris { get; set; }
        public DateTime? Cikis { get; set; }
    }
}
