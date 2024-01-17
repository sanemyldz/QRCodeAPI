using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectMevcutPersonel
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public int SicilId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string FirmaAd { get; set; } = null!;
        public int FirmaId { get; set; }
        public string? BirimAdi { get; set; }
        public int BirimId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public DateTime MesaiTarih { get; set; }
        public DateTime MesaiBas { get; set; }
        public int GorevId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string? IzinAdi { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
    }
}
