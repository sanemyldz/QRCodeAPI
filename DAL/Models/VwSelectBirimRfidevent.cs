using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectBirimRfidevent
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string AracPlaka { get; set; } = null!;
        public string Rfidad { get; set; } = null!;
        public string Rfidsoyad { get; set; } = null!;
        public int SicilId { get; set; }
        public int AracId { get; set; }
        public DateTime EventTime { get; set; }
        public string? CardId { get; set; }
        public string? FacilityCode { get; set; }
        public string? Aciklama { get; set; }
        public int TerminalId { get; set; }
        public string Name { get; set; } = null!;
        public string Yon { get; set; } = null!;
        public string? Yetki { get; set; }
        public string? BirimAdi { get; set; }
    }
}
