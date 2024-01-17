using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Email
    {
        public int Id { get; set; }
        public string? Rcptto { get; set; }
        public string? Subject { get; set; }
        public string? Data { get; set; }
        public DateTime? RecordDate { get; set; }
        public DateTime? ProcessDate { get; set; }
        public string? SicilId { get; set; }
        public DateTime? Tarih { get; set; }
    }
}
