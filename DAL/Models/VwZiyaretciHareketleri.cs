using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwZiyaretciHareketleri
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string PersonelNo { get; set; } = null!;
        public int BirimId { get; set; }
        public string Okod1 { get; set; } = null!;
        public string Okod2 { get; set; } = null!;
        public string Okod3 { get; set; } = null!;
        public string Okod4 { get; set; } = null!;
        public string Okod5 { get; set; } = null!;
        public DateTime EventTime { get; set; }
        public int TerminalId { get; set; }
        public string TerminalAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string Yon { get; set; } = null!;
        public string EventCode { get; set; } = null!;
        public string BirimAdi { get; set; } = null!;
    }
}
