using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserCardHistory
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public string CardIdHex { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
