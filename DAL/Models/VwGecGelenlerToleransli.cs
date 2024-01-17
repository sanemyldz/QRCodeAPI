using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGecGelenlerToleransli
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime? MesaiBaslangic { get; set; }
        public DateTime? MesaiBitis { get; set; }
        public int? GecFark { get; set; }
        public string? SicilNo { get; set; }
        public string Aciklama { get; set; } = null!;
        public DateTime? MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public int BirimId { get; set; }
        public string? BirimAdi { get; set; }
        public int BolumId { get; set; }
        public string BolumAd { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
    }
}
