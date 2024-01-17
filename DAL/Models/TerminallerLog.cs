using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TerminallerLog
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Model { get; set; }
        public string Port { get; set; } = null!;
        public int ControllerNo { get; set; }
        public int Io { get; set; }
        public int Function { get; set; }
        public int OpMode { get; set; }
        public int Kind { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
        public string? SonGecen { get; set; }
        public DateTime? SonTarih { get; set; }
        public DateTime? ZamanKontrol { get; set; }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public DateTime ConnectionTime { get; set; }
        public DateTime LastEventTime { get; set; }
        public int LongLogPeriod { get; set; }
        public int ShortLogPeriod { get; set; }
        public string SourceName { get; set; } = null!;
        public string CardFormat { get; set; } = null!;
        public int? PingCheck { get; set; }
        public int? Debug { get; set; }
        public int? TimeSend { get; set; }
        public int? ReaderCount { get; set; }
        public DateTime? LastAccounted { get; set; }
        public string? Door { get; set; }
        public int? X3 { get; set; }
        public int OperationMode { get; set; }
        public int Limit { get; set; }
        public int? FirmaId { get; set; }
        public DateTime? DoorStatusTime { get; set; }
        public string? Lokasyon { get; set; }
        public int? LastId { get; set; }
        public DateTime SonGelenKayitZamani { get; set; }
        public int LoginUserId { get; set; }
        public int IslemTipId { get; set; }
        public DateTime IslemDatetime { get; set; }
        public int TerminalId { get; set; }
    }
}
