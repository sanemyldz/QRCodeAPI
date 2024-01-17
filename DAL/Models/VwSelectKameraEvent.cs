using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectKameraEvent
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? SicilNo { get; set; }
        public DateTime FotoZamani { get; set; }
        public DateTime GecisZamani { get; set; }
        public string KameraAdi { get; set; } = null!;
        public string KameraIp { get; set; } = null!;
        public string? ResimYolu { get; set; }
        public int PoolId { get; set; }
        public int TerminalId { get; set; }
        public string TerminalAdi { get; set; } = null!;
        public string? FirmaAdi { get; set; }
        public int FirmaId { get; set; }
        public string? BolumAdi { get; set; }
        public int BolumId { get; set; }
        public string? GorevAdi { get; set; }
        public int GorevId { get; set; }
        public int PozisyonId { get; set; }
        public string? PozisyonAdi { get; set; }
        public string? BirimAdi { get; set; }
        public int BirimId { get; set; }
    }
}
