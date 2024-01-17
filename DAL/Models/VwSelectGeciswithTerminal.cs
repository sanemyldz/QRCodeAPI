using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectGeciswithTerminal
    {
        public int PoolId { get; set; }
        public DateTime EventTime { get; set; }
        public string TerminalAdi { get; set; } = null!;
        public int TerminalId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string SicilNo { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int SicilId { get; set; }
        public int BolumId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int BirimId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string EventCode { get; set; } = null!;
        public string TerminalGrupAdi { get; set; } = null!;
        public int TerminalGroupId { get; set; }
        public string Yon { get; set; } = null!;
        public string SirketAdi { get; set; } = null!;
        public string TaseronFirmaAdi { get; set; } = null!;
        public int TaseronFirmaId { get; set; }
        public int SirketId { get; set; }
        public string Gorev { get; set; } = null!;
        public string AmirAdi { get; set; } = null!;
    }
}
