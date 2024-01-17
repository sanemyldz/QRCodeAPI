using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KafeteryaLog
    {
        public int Id { get; set; }
        public int? MobilUserId { get; set; }
        public byte? IslemTur { get; set; }
        public int? SiparisIslemId { get; set; }
        public string? Aciklama { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
