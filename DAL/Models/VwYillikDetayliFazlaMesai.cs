using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwYillikDetayliFazlaMesai
    {
        public DateTime Tarih { get; set; }
        public int Yil { get; set; }
        public int Ay { get; set; }
        public int FazlaCalisma { get; set; }
        public int FazlaCalismaSaat { get; set; }
        public int FazlaCalismaDakika { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public int BirimId { get; set; }
        public int BolumId { get; set; }
        public int PozisyonId { get; set; }
        public int GorevId { get; set; }
        public int FirmaId { get; set; }
        public int SicilId { get; set; }
    }
}
