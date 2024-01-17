using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Moduller
    {
        public int Id { get; set; }
        public string? ModulKodu { get; set; }
        public string? ModulAdi { get; set; }
        public string? ParentId { get; set; }
    }
}
