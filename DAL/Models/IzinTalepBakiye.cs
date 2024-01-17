using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class IzinTalepBakiye
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public decimal? IzinBakiye { get; set; }
        public decimal? DevredenBakiye { get; set; }
        public DateTime? SonHesaplamaTarihi { get; set; }
        public decimal? KalanIzinGun { get; set; }
        public decimal? BakiyeFarkiGun { get; set; }
        public decimal? EkIzinGun { get; set; }
    }
}
