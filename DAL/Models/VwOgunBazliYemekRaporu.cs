using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwOgunBazliYemekRaporu
    {
        public int Id { get; set; }
        public DateTime EventTime { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public int SicilId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public string Okod1 { get; set; } = null!;
        public string Okod2 { get; set; } = null!;
        public int GorevId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string TerminalAdi { get; set; } = null!;
        public int TaseronFirmaId { get; set; }
        public string? TaseronFirmaAdı { get; set; }
        public int TerminalId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public int BirimId { get; set; }
        public int Dakika { get; set; }
        public int SabahKahvaltısı { get; set; }
        public int OgleYemegi { get; set; }
        public int AksamYemegi { get; set; }
        public int GeceYemegi { get; set; }
        public string Port { get; set; } = null!;
    }
}
