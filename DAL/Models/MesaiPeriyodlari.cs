using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MesaiPeriyodlari
    {
        public MesaiPeriyodlari()
        {
            MesaiPeriyodlariUyeleris = new HashSet<MesaiPeriyodlariUyeleri>();
        }

        public int Id { get; set; }
        public string Aciklama { get; set; } = null!;
        public bool Varsayilan { get; set; }
        public bool? OtomatikTatil { get; set; }
        public int? TatilGunHakki { get; set; }
        public bool? HakEdilenTatil { get; set; }
        public int? HakEdilenTatilEsikDegeri { get; set; }
        public bool? TumHaftaOtomatikTatilEtkin { get; set; }
        public string? OtomatikTatilGunler { get; set; }
        public string? EntegrasyonKod { get; set; }

        public virtual ICollection<MesaiPeriyodlariUyeleri> MesaiPeriyodlariUyeleris { get; set; }
    }
}
