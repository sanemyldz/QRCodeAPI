﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PoolSuspect
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public string? UserId { get; set; }
        public int? TerminalId { get; set; }
        public DateTime? EventTime { get; set; }
        public string? EventCode { get; set; }
        public int? FuncCode { get; set; }
        public bool? Automatic { get; set; }
        public int? Deleted { get; set; }
        public int? Pdks { get; set; }
        public int? ReaderId { get; set; }
        public string? Status { get; set; }
        public bool? UnDelete { get; set; }
        public long? ForeignId { get; set; }
        public int? Pdksx { get; set; }
    }
}
