using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilGunlukMesaiOzeti
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int TasnifId { get; set; }
        public int? GecGeldi { get; set; }
        public int? ErkenCikti { get; set; }
        public int? EksikCalisma { get; set; }
        public int? FazlaCalisma { get; set; }
        public int? MesaiSuresi { get; set; }
        public int? HataliGecis { get; set; }
        public int? TotalIceridekiSure { get; set; }
        public int? TotalDinlenmeSure { get; set; }
        public int? OglenCikisPoolId { get; set; }
        public int? OglenGirisPoolId { get; set; }
        public int? OglenMolaSure { get; set; }
        public string? Ozet { get; set; }
        public string? OglenDurum { get; set; }
        public DateTime? MesaiBasSonrasiIlkGiris { get; set; }
        public DateTime? MesaiBitOncesiSonCikis { get; set; }
        public DateTime? IlkGiris { get; set; }
        public DateTime? SonCikis { get; set; }
        public int? GerceklesenMesaiId { get; set; }
        public int? CurrentBirimId { get; set; }
        public int? GeceMesaiSure { get; set; }
        public int? GeceDinlenmeToplamSure { get; set; }
        public int? GeceDinlenmeCalismaSure { get; set; }
        public int? GeceFazlaMesai { get; set; }
        public int? MesaiIciToplamIcerdekiSure { get; set; }
        public int? MesaiDisiToplamIcerdekiSure { get; set; }
        public int? MesaiOncesiToplamIcerdekiSure { get; set; }
        public int? GeceMesaiIciCalisma { get; set; }
        public int? CekirdekCalismaSure { get; set; }
        public int? TelafiCalismaSure { get; set; }
        public int? EsnekDinlenmedeFazlaKullanilanDinlenmeSure { get; set; }
        public int? MesaiIciCalismaSure { get; set; }
        public int? ResmiTatilFazlaMesai { get; set; }
        public string? GorevlendirmeKod { get; set; }
        public int? GorevlendirmeSure { get; set; }
        public int? GorevlendirmeId { get; set; }
    }
}
