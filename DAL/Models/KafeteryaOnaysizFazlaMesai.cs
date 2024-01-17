using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KafeteryaOnaysizFazlaMesai
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public decimal? IcecekDusum { get; set; }
        public decimal? YiyecekDusum { get; set; }
        public DateTime? Tarih { get; set; }
    }
}
