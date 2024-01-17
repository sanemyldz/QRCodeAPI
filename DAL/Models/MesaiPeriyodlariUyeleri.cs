using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MesaiPeriyodlariUyeleri
    {
        public int Id { get; set; }
        public int PeriyodId { get; set; }
        public int GrupId { get; set; }
        public int SiraNo { get; set; }
        public string Aciklama { get; set; } = null!;

        public virtual MesaiGruplari Grup { get; set; } = null!;
        public virtual MesaiPeriyodlari Periyod { get; set; } = null!;
    }
}
