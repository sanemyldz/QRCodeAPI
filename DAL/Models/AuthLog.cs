using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AuthLog
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public byte? LogType { get; set; }
        public string? CardId { get; set; }
        public string? CardIdHex { get; set; }
        public string? Message { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
