using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGunlukGelmeyenlerRaporu
    {
        public int SicilId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? BolumAdi { get; set; }
        public DateTime MesaiTarih { get; set; }
        public string? FirmaAdi { get; set; }
        public string? GorevAdi { get; set; }
        public string Aciklama { get; set; } = null!;
        public int FirmaId { get; set; }
        public int GorevId { get; set; }
        public int BolumId { get; set; }
        public int BirimId { get; set; }
    }
}
