using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MesaiGruplari
    {
        public MesaiGruplari()
        {
            MesaiGruplariUyeleris = new HashSet<MesaiGruplariUyeleri>();
            MesaiPeriyodlariUyeleris = new HashSet<MesaiPeriyodlariUyeleri>();
            SicilHaftaTatilis = new HashSet<SicilHaftaTatili>();
        }

        public int Id { get; set; }
        public string Aciklama { get; set; } = null!;
        public string? OncelikliBirimAdi { get; set; }
        public int MesaiYakalamaId { get; set; }

        public virtual MesaiYakalamaTipleri MesaiYakalama { get; set; } = null!;
        public virtual ICollection<MesaiGruplariUyeleri> MesaiGruplariUyeleris { get; set; }
        public virtual ICollection<MesaiPeriyodlariUyeleri> MesaiPeriyodlariUyeleris { get; set; }
        public virtual ICollection<SicilHaftaTatili> SicilHaftaTatilis { get; set; }
    }
}
