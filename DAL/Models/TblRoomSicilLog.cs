using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblRoomSicilLog
    {
        public int Id { get; set; }
        public int? RoomId { get; set; }
        public int? SicilId { get; set; }
        public DateTime? BaslangicTarih { get; set; }
        public int LoginUserId { get; set; }
        public int IslemTipId { get; set; }
        public DateTime IslemTarih { get; set; }
    }
}
