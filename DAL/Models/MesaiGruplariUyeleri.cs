using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MesaiGruplariUyeleri
    {
        public int Id { get; set; }
        public int GrupId { get; set; }
        public int MesaiId { get; set; }
        public string Aciklama { get; set; } = null!;
        public int KapsamaAlaniBasi { get; set; }
        public int KapsamaAlaniSonu { get; set; }
        public bool OncelikliBirim { get; set; }

        public virtual MesaiGruplari Grup { get; set; } = null!;
        public virtual Mesailer Mesai { get; set; } = null!;
    }
}
