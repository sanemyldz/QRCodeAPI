using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSonGeci
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? SicilNo { get; set; }
        public DateTime? Eventtime { get; set; }
        public int? TerminalId { get; set; }
        public string? TerminalAdi { get; set; }
        public string? KapiDurum { get; set; }
        public DateTime? KapiOlayZamani { get; set; }
        public int? PoolId { get; set; }
    }
}
