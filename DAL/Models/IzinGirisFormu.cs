using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class IzinGirisFormu
    {
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? Tcno { get; set; }
        public string? BirimAdi { get; set; }
        public DateTime IseGirisTar { get; set; }
        public DateTime IzinBaslangicTar { get; set; }
        public DateTime IzinBitisTar { get; set; }
        public int IzinGun { get; set; }
        public DateTime IseBaslamaTarih { get; set; }
        public string? Adres { get; set; }
        public string IzinAd { get; set; } = null!;
        public int SicilId { get; set; }
        public string? UserId { get; set; }
        public int IzinId { get; set; }
    }
}
