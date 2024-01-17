using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string Message1 { get; set; } = null!;
        public int MessageCount { get; set; }

        public virtual Sicil Sicil { get; set; } = null!;
    }
}
