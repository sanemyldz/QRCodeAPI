using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblRoomLog
    {
        public int Id { get; set; }
        public int? ContainerId { get; set; }
        public int? YatakSayisi { get; set; }
        public decimal? GunlukUcret { get; set; }
        public string? Adi { get; set; }
        public int LoginUserId { get; set; }
        public int IslemTipId { get; set; }
        public DateTime IslemTarih { get; set; }
    }
}
