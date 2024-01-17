using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class RawDataOzet
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime Eventtime { get; set; }
        public string Ip { get; set; } = null!;
        public int ReaderId { get; set; }
        public string EventCode { get; set; } = null!;
        public string FuncCode { get; set; } = null!;
        public DateTime InsertDate { get; set; }
        public byte[]? Image { get; set; }
        public bool? FileAktarildi { get; set; }
        public int? SicilId { get; set; }
        public string? UserIdfixed { get; set; }
    }
}
