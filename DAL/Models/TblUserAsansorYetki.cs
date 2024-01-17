using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblUserAsansorYetki
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int? AsansorId { get; set; }
        public int? KatYetki { get; set; }
    }
}
