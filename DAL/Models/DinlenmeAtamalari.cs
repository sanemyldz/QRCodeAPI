using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DinlenmeAtamalari
    {
        public int Id { get; set; }
        public int MesaiId { get; set; }
        public int DinlenmeId { get; set; }
        public string? Aciklama { get; set; }

        public virtual Dinlenmeler Dinlenme { get; set; } = null!;
        public virtual Mesailer Mesai { get; set; } = null!;
    }
}
