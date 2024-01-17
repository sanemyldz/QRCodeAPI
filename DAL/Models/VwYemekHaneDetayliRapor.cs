using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwYemekHaneDetayliRapor
    {
        public int SicilNo { get; set; }
        public string? PersonelNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public int GorevId { get; set; }
        public int BirimId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public DateTime SonOkutmaSaati { get; set; }
        public string Name { get; set; } = null!;
    }
}
