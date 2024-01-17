using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CboSirketArac
    {
        public int Id { get; set; }
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public string? Plaka { get; set; }
        public string? ModelYili { get; set; }
        public string? Sigorta { get; set; }
        public string? Kasko { get; set; }
        public DateTime? MuayeneTarihi { get; set; }
        public string? Tip { get; set; }
    }
}
