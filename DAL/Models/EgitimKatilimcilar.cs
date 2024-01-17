using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EgitimKatilimcilar
    {
        public int Id { get; set; }
        public int? EgitimId { get; set; }
        public int? SicilId { get; set; }

        public virtual Egitimler? Egitim { get; set; }
        public virtual Sicil? Sicil { get; set; }
    }
}
