using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HysTblSeyahatler
    {
        public int Id { get; set; }
        public int TalepId { get; set; }
        public int UlasimId { get; set; }
        public DateTime Tarih { get; set; }
        public string Nereden { get; set; } = null!;
        public string Nereye { get; set; } = null!;
        public int? Gorev { get; set; }
        public string? Aciklama { get; set; }
        public bool? Konaklama { get; set; }
        public string? Otel { get; set; }

        public virtual HysTblGorevler? GorevNavigation { get; set; }
        public virtual HysTblSeyahatIstekleri Talep { get; set; } = null!;
        public virtual HysTblUlasimAraclari Ulasim { get; set; } = null!;
    }
}
