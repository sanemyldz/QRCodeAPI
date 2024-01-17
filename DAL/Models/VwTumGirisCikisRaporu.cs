using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwTumGirisCikisRaporu
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string PersonelNo { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime EventTime { get; set; }
        public int TerminalId { get; set; }
        public int FuncCode { get; set; }
        public int Io { get; set; }
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int PozisyonId { get; set; }
        public int GorevId { get; set; }
        public string BolumAd { get; set; } = null!;
        public string FirmaAd { get; set; } = null!;
        public string GorevAd { get; set; } = null!;
        public string PozisyonAd { get; set; } = null!;
        public string KartNo { get; set; } = null!;
        public string TerminalName { get; set; } = null!;
        public int TerminalGroupId { get; set; }
    }
}
