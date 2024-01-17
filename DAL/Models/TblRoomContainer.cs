using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblRoomContainer
    {
        public int Id { get; set; }
        public int? BirimId { get; set; }
        public string? Adi { get; set; }
        public bool? Deleted { get; set; }
    }
}
