using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblRoomContainerLog
    {
        public int Id { get; set; }
        public int? BirimId { get; set; }
        public string? Adi { get; set; }
        public int LoginUserId { get; set; }
        public int IslemTipId { get; set; }
        public DateTime IslemTarih { get; set; }
    }
}
