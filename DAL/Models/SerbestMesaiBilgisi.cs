using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SerbestMesaiBilgisi
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public DateTime? Mesaibasi { get; set; }
        public DateTime? Mesaisonu { get; set; }

        public virtual Sicil Sicil { get; set; } = null!;
    }
}
