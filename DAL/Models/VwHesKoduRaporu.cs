using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwHesKoduRaporu
    {
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string Tckn { get; set; } = null!;
        public string HesKodu { get; set; } = null!;
        public DateTime SorguTarih { get; set; }
        public int SaglikDurum { get; set; }
        public int FirmaId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAdi { get; set; } = null!;
    }
}
