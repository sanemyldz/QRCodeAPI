using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Pass24
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public DateTime Tarih { get; set; }

        public virtual Sicil Sicil { get; set; } = null!;
    }
}
