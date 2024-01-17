using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectTerminalAlarmStatus
    {
        public string Name { get; set; } = null!;
        public int Id { get; set; }
        public string Port { get; set; } = null!;
        public int? PanelPortNo { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? SicilNo { get; set; }
        public DateTime? Eventtime { get; set; }
        public string? SonBaglantiOlayi { get; set; }
        public DateTime? SonBaglantiZamani { get; set; }
        public bool? CihazBagli { get; set; }
        public DateTime? SonKapiIslemi { get; set; }
        public string? SonKapiDurumu { get; set; }
        public bool? KapiAcik { get; set; }
        public bool? UzunSureAcikKaldi { get; set; }
        public DateTime? CihazSonIslemZamani { get; set; }
        public string? CihazSokulmeDurum { get; set; }
        public bool? CihazSokuldu { get; set; }
        public DateTime? SonAlarm { get; set; }
    }
}
