using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Bordro
    {
        public int Id { get; set; }
        public string? Tarih { get; set; }
        public int? SicilId { get; set; }
        public int? Ba { get; set; }
        public string? Tutar { get; set; }
        public string? Aciklama { get; set; }
    }
}
