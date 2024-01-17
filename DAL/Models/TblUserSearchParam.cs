using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblUserSearchParam
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? BirimId { get; set; }
        public string? BolumId { get; set; }
        public string? FirmaId { get; set; }
        public string? PozisyonId { get; set; }
        public string? GorevId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public DateTime? BasTar { get; set; }
        public DateTime? BitTar { get; set; }
        public DateTime? TekTar { get; set; }
        public string? Okod1 { get; set; }
        public string? Okod2 { get; set; }
        public string? Okod3 { get; set; }
        public string? Okod4 { get; set; }
        public string? Okod5 { get; set; }
        public string? TerminalGrupId { get; set; }
        public string? TerminalLokasyonId { get; set; }
        public string? TerminalId { get; set; }
        public bool? IstenAyrilanPersonel { get; set; }
        public string? TcNo { get; set; }
        public string? SicilNo { get; set; }
        public string? YetkiId { get; set; }
        public int? ManGecTolerans { get; set; }
        public int? ManErkenTolerans { get; set; }
        public string? SicilId { get; set; }
        public bool? AltBirim { get; set; }
        public string? IzinTipId { get; set; }
        public string? MesaiId { get; set; }
        public string? TaseronFirmaId { get; set; }
        public string? GorevTuru { get; set; }
        public string? KartSicilId { get; set; }

        public virtual UserTable User { get; set; } = null!;
    }
}
