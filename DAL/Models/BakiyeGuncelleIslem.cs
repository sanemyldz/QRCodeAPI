using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class BakiyeGuncelleIslem
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public decimal? GuncellenecekBakiye { get; set; }
        public decimal? GuncellenecekYiyecekBakiye { get; set; }
        public decimal? GuncellenecekIcecekBakiye { get; set; }
        public DateTime? BaslangicTarih { get; set; }
        public int? UserId { get; set; }
        public DateTime? Tarih { get; set; }
        public bool? Islendi { get; set; }
        public DateTime? IslemTarih { get; set; }
    }
}
