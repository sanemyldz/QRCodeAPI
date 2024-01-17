using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwCalismaPlani
    {
        public string? ResmiTatilAciklama { get; set; }
        public int TasnifId { get; set; }
        public string? MesaiAdi { get; set; }
        public string? MesaiGrupAdi { get; set; }
        public string? MesaiPeriyodu { get; set; }
        public bool OtomatikTatil { get; set; }
        public int TatilGunSayisi { get; set; }
        public int SicilId { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public DateTime? BaslangicTarihSaat { get; set; }
        public DateTime? BitisTarihSaat { get; set; }
        public string? GunAdi { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? MesaiAciklama { get; set; }
        public DateTime Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public bool? GeceMesaisi { get; set; }
        public int? MesaiBas { get; set; }
        public int? MesaiBit { get; set; }
        public int MesaiGrubu { get; set; }
        public int MesaiBirimi { get; set; }
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
    }
}
