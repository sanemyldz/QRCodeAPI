using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MailDuty
    {
        public int Id { get; set; }
        public string? To { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public DateTime? Recorddate { get; set; }
        public DateTime? SendTime { get; set; }
        public string? Result { get; set; }
    }
}
