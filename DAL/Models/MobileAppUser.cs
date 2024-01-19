using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MobileAppUser
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public string? SicilNo { get; set; }
        public string? Password { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpirationDate { get; set; }
    }
}
