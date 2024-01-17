using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwMesaiHesapSaglama
    {
        public string? Ozet { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? Sicilno { get; set; }
        public string? Itfaciklama { get; set; }
        public string? Sgfaciklama { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public int SicilId { get; set; }
        public int? PoolGecisSayisi { get; set; }
        public DateTime? PoolIkGiris { get; set; }
        public DateTime? PoolSonCikis { get; set; }
        public DateTime Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public int? AraSureToplam { get; set; }
        public int? TotalIceridekiSure { get; set; }
        public int? TotalDinlenmeSure { get; set; }
        public DateTime? MesaiBasSonrasiIlkGiris { get; set; }
        public DateTime? MesaiBitOncesiSonCikis { get; set; }
        public DateTime? IlkGiris { get; set; }
        public DateTime? SonCikis { get; set; }
    }
}
