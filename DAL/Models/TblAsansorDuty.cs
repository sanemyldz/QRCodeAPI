using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblAsansorDuty
    {
        public int Id { get; set; }
        public int? TerminalId { get; set; }
        public string? UserId { get; set; }
        public short? AuthCommand { get; set; }
        public short? FloorNumber { get; set; }
        public DateTime? RecordDate { get; set; }
        public DateTime? ProcessDate { get; set; }
        public string? Result { get; set; }
    }
}
