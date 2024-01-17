﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwYemekhaneOgunRaporu0421
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string? SicilNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime Zaman { get; set; }
        public string Terminal { get; set; } = null!;
        public string Ogun { get; set; } = null!;
        public int GorevId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public int BirimId { get; set; }
        public string? BirimAdi { get; set; }
    }
}
