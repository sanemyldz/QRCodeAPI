using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblIlaveYetkiLog
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public int? TerminalId { get; set; }
        public int? YetkiId { get; set; }
        public string? UserId { get; set; }
        public int LoginUserId { get; set; }
        public int IslemTipId { get; set; }
        public DateTime IslemDatetime { get; set; }
        public int IlaveYetkiId { get; set; }
    }
}
