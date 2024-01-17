using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserAuthStatus
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int? PanelId { get; set; }
        public bool? Authorized { get; set; }
    }
}
