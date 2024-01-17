using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSonOdaHareketi
    {
        public int Id { get; set; }
        public int? OdaId { get; set; }
        public int? SicilId { get; set; }
        public bool? Iceride { get; set; }
        public int? SonPoolId { get; set; }
        public DateTime? SonEventTime { get; set; }
    }
}
