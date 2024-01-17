using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblRoomSicilHareket
    {
        public int Id { get; set; }
        public int? TasnifId { get; set; }
        public decimal? GunlukUcret { get; set; }
        public int? RoomId { get; set; }
    }
}
