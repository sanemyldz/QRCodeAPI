using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilKalanKullanilanIzin
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int IzinKuralId { get; set; }
        public decimal ToplamHakEdilenIzinGun { get; set; }
        public int ToplamHakEdilenIzinSaat { get; set; }
        public decimal ToplamKullanilanIzinGun { get; set; }
        public int ToplamKullanilanIzinSaat { get; set; }
        public decimal ToplamKalanIzinGun { get; set; }
        public int ToplamKalanIzinSaat { get; set; }
        public decimal? BakiyeFarkiGun { get; set; }
        public int? BakiyeFarkiSaat { get; set; }
        public decimal? AktarilanDevirGun { get; set; }
        public int? AktarilanDevirSaat { get; set; }

        public virtual TblIzinTanimKurali IzinKural { get; set; } = null!;
        public virtual Sicil Sicil { get; set; } = null!;
    }
}
