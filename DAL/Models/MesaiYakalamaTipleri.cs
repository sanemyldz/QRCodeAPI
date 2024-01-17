using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MesaiYakalamaTipleri
    {
        public MesaiYakalamaTipleri()
        {
            MesaiGruplaris = new HashSet<MesaiGruplari>();
        }

        public int Id { get; set; }
        public string? Tip { get; set; }

        public virtual ICollection<MesaiGruplari> MesaiGruplaris { get; set; }
    }
}
