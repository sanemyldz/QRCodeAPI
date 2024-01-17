﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwTasnifDisiGecisler
    {
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string Tcno { get; set; } = null!;
        public int? BirimId { get; set; }
        public int? FirmaId { get; set; }
        public int? BolumId { get; set; }
        public int? GorevId { get; set; }
        public int? PozisyonId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public DateTime EventTime { get; set; }
        public int TerminalId { get; set; }
        public string TerminalAdi { get; set; } = null!;
        public string Yon { get; set; } = null!;
        public int YonId { get; set; }
    }
}
