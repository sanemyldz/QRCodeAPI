using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Userlimit
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? TerminalId { get; set; }
        public int Limit { get; set; }
    }
}
