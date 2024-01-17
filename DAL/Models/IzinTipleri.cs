using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class IzinTipleri
    {
        public IzinTipleri()
        {
            Izinlers = new HashSet<Izinler>();
            TblIzinKidemKuralis = new HashSet<TblIzinKidemKurali>();
            TblIzinLimitKuralis = new HashSet<TblIzinLimitKurali>();
            TblIzinYasKuralis = new HashSet<TblIzinYasKurali>();
        }

        public int Id { get; set; }
        public string Aciklama { get; set; } = null!;
        public int VarsayilanSure { get; set; }
        public bool Saatlikizin { get; set; }
        public string Kod { get; set; } = null!;
        public bool Ucretli { get; set; }
        public bool? UstUsteAlinabilir { get; set; }
        public bool? CalismaSuresikadar { get; set; }
        public bool? TatilleriYoksay { get; set; }
        public string? EntegrasyonKod { get; set; }
        public bool? PazarResmiTatilYoksay { get; set; }

        public virtual ICollection<Izinler> Izinlers { get; set; }
        public virtual ICollection<TblIzinKidemKurali> TblIzinKidemKuralis { get; set; }
        public virtual ICollection<TblIzinLimitKurali> TblIzinLimitKuralis { get; set; }
        public virtual ICollection<TblIzinYasKurali> TblIzinYasKuralis { get; set; }
    }
}
