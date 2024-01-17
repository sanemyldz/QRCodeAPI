using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwUnauthorizedCardAccessGateIo
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? SicilNo { get; set; }
        public string? PersonelNo { get; set; }
        public string? CardId { get; set; }
        public DateTime? EventTime { get; set; }
        public string? UserId { get; set; }
        public string? BolumAd { get; set; }
        public int? BolumId { get; set; }
        public string? BirimAd { get; set; }
        public int? BirimId { get; set; }
        public string? PozisyonAd { get; set; }
        public int? PozisyonId { get; set; }
        public int? TerminalId { get; set; }
        public string? TerminalAd { get; set; }
    }
}
