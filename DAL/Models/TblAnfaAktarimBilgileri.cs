using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblAnfaAktarimBilgileri
    {
        public int? Id { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string? Tcno { get; set; }
        public DateTime? IseGiris { get; set; }
        public string? Khkdurumu { get; set; }
        public string? Birimi { get; set; }
        public string? Kadrosu { get; set; }
        public string? MeslekAdi { get; set; }
        public string? GorevYeri { get; set; }
        public string? FiilenYapılanIs { get; set; }
        public string? UcretTipi { get; set; }
        public decimal? NetMaas { get; set; }
        public decimal? BrutMaas { get; set; }
        public string? GorevlendirildigiYer { get; set; }
        public string? Mezuniyet { get; set; }
        public string? MezunOlduguOkul { get; set; }
        public string? MezunOlduguBolum { get; set; }
        public string? MezunOlduguAlan { get; set; }
        public DateTime? MezuniyetTarihi { get; set; }
        public string? Ehliyet { get; set; }
        public string? EhliyetveBelgeTarih { get; set; }
        public string? Sertifika { get; set; }
        public string? BabaAdi { get; set; }
        public string? DogumYeri { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? Telefon { get; set; }
        public string? Referansı { get; set; }
        public string? Cinsiyet { get; set; }
        public string? Engelli { get; set; }
        public string? Adres { get; set; }
        public string? Ilce { get; set; }
        public string? GeciciDaimi { get; set; }
        public string? KhkgecisKadro { get; set; }
    }
}
