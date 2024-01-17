using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UrunFiyatGuncelleIslem
    {
        public int Id { get; set; }
        public int? UrunId { get; set; }
        public decimal? Fiyat { get; set; }
        public DateTime? BaslangicTarih { get; set; }
        public int? UserId { get; set; }
        public DateTime? Tarih { get; set; }
        public bool? Islendi { get; set; }
        public DateTime? IslemTarih { get; set; }
    }
}
