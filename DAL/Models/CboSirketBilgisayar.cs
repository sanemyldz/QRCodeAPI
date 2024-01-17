using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CboSirketBilgisayar
    {
        public int Id { get; set; }
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public string? SeriNo { get; set; }
    }
}
