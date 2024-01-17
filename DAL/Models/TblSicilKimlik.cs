using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilKimlik
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string? KimlikSeri { get; set; }
        public string? KimlikNo { get; set; }
        public string? BabaAdi { get; set; }
        public string? BabaYasamDurumu { get; set; }
        public string? AnneAdi { get; set; }
        public string? AnneYasamDurumu { get; set; }
        public string? DogumYeri { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? MedeniHal { get; set; }
        public string? Din { get; set; }
        public string? KanGrubu { get; set; }
        public string? KayitliOlduguIl { get; set; }
        public string? KayitliOlduguIlce { get; set; }
        public string? KayitliOlduguMahalle { get; set; }
        public string? KayitliOlduguCiltNo { get; set; }
        public string? AileSiraNo { get; set; }
        public string? SiraNo { get; set; }
        public string? CuzdaninVerildigiYer { get; set; }
        public string? CuzdaninVerilisNedeni { get; set; }
        public string? CuzdaninKayitNo { get; set; }
        public DateTime? CuzdaninVerilisTarihi { get; set; }
        public string? OncekiSoyad { get; set; }
        public string? CalismaDurumu { get; set; }
        public string? Cinsiyet { get; set; }
        public string? AskerlikDurumu { get; set; }
        public string? EgitimDurumu { get; set; }
        public int? Boy { get; set; }
        public int? Kilo { get; set; }
        public int? AyakkabiNo { get; set; }
        public int? ElbiseBedeni { get; set; }
        public string? YabanciDil1 { get; set; }
        public string? YabanciDil1Durum { get; set; }
        public string? YabanciDil2 { get; set; }
        public string? YabanciDil2Durum { get; set; }
        public string? YabanciDil3 { get; set; }
        public string? YabanciDil3Durum { get; set; }
        public string? Ehliyet { get; set; }
        public string? EhliyetTarih { get; set; }
        public DateTime? TecilTarih { get; set; }
        public DateTime? SgkSicilNo { get; set; }
        public string? TisortBeden { get; set; }
        public string? PantolonBeden { get; set; }
        public string? ServisDurak { get; set; }
        public string? Tc { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
    }
}
