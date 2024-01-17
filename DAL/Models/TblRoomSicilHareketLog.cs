using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblRoomSicilHareketLog
    {
        public int Id { get; set; }
        public int? TasnifId { get; set; }
        public decimal? GunlukUcret { get; set; }
        public int LoginUserId { get; set; }
        public int IslemTipId { get; set; }
        public DateTime IslemTarih { get; set; }
    }
}
