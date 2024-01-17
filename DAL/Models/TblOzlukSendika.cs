using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblOzlukSendika
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int? SendikaDurum { get; set; }
        public DateTime? BaslangicTarih { get; set; }
        public DateTime? BitisTarih { get; set; }
        public string? CikisNeden { get; set; }
        public int? SendikaUnvan { get; set; }
    }
}
