using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectgecisresim
    {
        public int Id { get; set; }
        public int RowDataozetId { get; set; }
        public byte[]? Resim { get; set; }
        public bool? FileAktarildi { get; set; }
        public DateTime Eventtime { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? PersonelNo { get; set; }
        public string? SicilNo { get; set; }
        public int? FirmaId { get; set; }
        public int? BolumId { get; set; }
        public int? PozisyonId { get; set; }
        public int? GorevId { get; set; }
        public int? BirimId { get; set; }
        public int SicilId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public string? Okod1 { get; set; }
        public int TerminalId { get; set; }
        public string TerminalAdi { get; set; } = null!;
        public string Yon { get; set; } = null!;
    }
}
