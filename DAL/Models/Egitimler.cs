using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Egitimler
    {
        public Egitimler()
        {
            EgitimKatilimcilars = new HashSet<EgitimKatilimcilar>();
        }

        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string? EgitimTipi { get; set; }
        public string? FinansTipi { get; set; }
        public string? Organizator { get; set; }
        public string? Lokasyon { get; set; }
        public DateTime? BaslangicZamani { get; set; }
        public DateTime? BitisZamani { get; set; }
        public string? Aciklama { get; set; }
        public string? EgitimiVerenKurum { get; set; }
        public int? EgitmenSicilId { get; set; }
        public string? EgitmenDis { get; set; }
        public bool? PlansizEgitim { get; set; }

        public virtual Sicil? EgitmenSicil { get; set; }
        public virtual ICollection<EgitimKatilimcilar> EgitimKatilimcilars { get; set; }
    }
}
