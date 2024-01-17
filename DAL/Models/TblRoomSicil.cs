using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblRoomSicil
    {
        public int Id { get; set; }
        public int? RoomId { get; set; }
        public int? SicilId { get; set; }
        public DateTime? BaslangicTarih { get; set; }
        public bool? Deleted { get; set; }
    }
}
