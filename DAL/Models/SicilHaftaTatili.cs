using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SicilHaftaTatili
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int MesailerId { get; set; }
        public int MesaiGruplariId { get; set; }
        public byte Gun { get; set; }

        public virtual MesaiGruplari MesaiGruplari { get; set; } = null!;
        public virtual Mesailer Mesailer { get; set; } = null!;
        public virtual Sicil Sicil { get; set; } = null!;
    }
}
