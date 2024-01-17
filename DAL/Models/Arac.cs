using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Arac
    {
        public int Id { get; set; }
        public int Tur { get; set; }
        public int Gorevli { get; set; }
        public int Cins { get; set; }
        public string Plaka { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? Firma { get; set; }
        public int? GeldigiBolum { get; set; }
        public string? GidecegiYer { get; set; }
        public DateTime? Giris { get; set; }
        public int? GirisKm { get; set; }
        public DateTime? Cikis { get; set; }
        public int? CikisKm { get; set; }
        public string? Bilgi { get; set; }

        public virtual CboAracCinsi CinsNavigation { get; set; } = null!;
        public virtual CboGorevli GorevliNavigation { get; set; } = null!;
    }
}
