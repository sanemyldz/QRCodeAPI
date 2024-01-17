using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Sifre
    {
        public int Id { get; set; }
        public string? NewUserId { get; set; }
        public string? OldUserId { get; set; }
        public DateTime? RecordDate { get; set; }
        public DateTime? ProcessDate { get; set; }
    }
}
