using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SicilAttach
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int SicilAddFieldId { get; set; }
        public string? Deger { get; set; }

        public virtual Sicil Sicil { get; set; } = null!;
        public virtual CboSicil SicilAddField { get; set; } = null!;
    }
}
