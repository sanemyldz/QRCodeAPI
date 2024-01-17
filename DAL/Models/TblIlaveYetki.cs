using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblIlaveYetki
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public int? TerminalId { get; set; }
        public int? YetkiId { get; set; }
        public string? UserId { get; set; }
    }
}
