using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KafeteryaKalanHakLog
    {
        public int Id { get; set; }
        public string? Aciklama { get; set; }
        public int? UserId { get; set; }
        public DateTime? Zaman { get; set; }
    }
}
