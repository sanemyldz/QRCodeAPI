using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class YetkiLog
    {
        public int Id { get; set; }
        public string? Aciklama { get; set; }
        public int? Gonder { get; set; }
        public string? AciklamaDetay { get; set; }
        public int LoginUserId { get; set; }
        public int IslemTipId { get; set; }
        public DateTime IslemDatetime { get; set; }
        public int YetkiId { get; set; }
    }
}
