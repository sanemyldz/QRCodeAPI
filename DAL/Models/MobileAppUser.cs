using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MobileAppUser
    {
        public string? SicilNo { get; set; }
        public string? Password { get; set; }
        public int Id { get; set; }
        public string? RefreshToken { get; set; }
    }
}
