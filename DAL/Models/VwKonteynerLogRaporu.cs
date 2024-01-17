using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwKonteynerLogRaporu
    {
        public int IslemId { get; set; }
        public int LoginUserId { get; set; }
        public string KullaniciAdi { get; set; } = null!;
        public int IslemTipId { get; set; }
        public string? IslemTipAdi { get; set; }
        public DateTime IslemTarih { get; set; }
        public string? KonteynerAdi { get; set; }
        public int YatakSayisi { get; set; }
        public decimal GunlukUcret { get; set; }
        public string? OdaAdi { get; set; }
        public string Adi { get; set; } = null!;
        public string Soyadi { get; set; } = null!;
        public int SicilId { get; set; }
        public int BirimId { get; set; }
        public string? SantiyeAdi { get; set; }
        public string KonteynerLogTipi { get; set; } = null!;
    }
}
