using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilBirimLog
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int EskiBirimId { get; set; }
        public int YeniBirimId { get; set; }
        public DateTime IslemDatetime { get; set; }
        public int UserId { get; set; }

        public virtual Sicil Sicil { get; set; } = null!;
        public virtual UserTable User { get; set; } = null!;
    }
}
