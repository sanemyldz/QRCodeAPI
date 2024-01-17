using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectLedPanelEvent
    {
        public int Id { get; set; }
        public DateTime? Eventtime { get; set; }
        public int? SicilId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? PictureId { get; set; }
        public string? SicilNo { get; set; }
        public string? KullaniciAciklama { get; set; }
        public string? LedPanelAciklama { get; set; }
        public string? EnEventName { get; set; }
        public string? TrEventName { get; set; }
        public string? Description { get; set; }
        public string? CardId { get; set; }
        public int? UserDef { get; set; }
        public string? CardId26 { get; set; }
        public string? KayitTipi { get; set; }
        public string? Model { get; set; }
        public string? Marka { get; set; }
        public string? AracPlaka { get; set; }
        public int? TerminalId { get; set; }
        public string TerminalAdi { get; set; } = null!;
        public string? LedPanelAdi { get; set; }
        public string? LedPanelIp { get; set; }
        public string? GuvenlikNotu { get; set; }
        public string? BirimAdi { get; set; }
        public string? BolumAdi { get; set; }
        public string? PozisyonAdi { get; set; }
    }
}
