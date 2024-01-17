using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SelectSicilOzelYetki
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string? PersonelNo { get; set; }
        public string? SicilNo { get; set; }
        public string Soyad { get; set; } = null!;
        public DateTime? GirisTarih { get; set; }
        public int? AmirId { get; set; }
        public DateTime? CikisTarih { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string? GorevAdi { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int? BirimKodu { get; set; }
        public string? BirimAdi { get; set; }
        public int FirmaId { get; set; }
        public int PozisyonId { get; set; }
        public int? GorevId { get; set; }
        public int BolumId { get; set; }
        public bool Deleted { get; set; }
        public string? Telefon1 { get; set; }
        public string? CepTelefon { get; set; }
        public string? Adres { get; set; }
        public string? Okod1 { get; set; }
        public string? Okod2 { get; set; }
        public string? Okod3 { get; set; }
        public string? Okod4 { get; set; }
        public string? Okod5 { get; set; }
        public string? Okod6 { get; set; }
        public string? Bilgi { get; set; }
        public int? BirimId { get; set; }
        public bool FazlaMesai { get; set; }
        public string? AmirAdi { get; set; }
        public DateTime ExpireDate { get; set; }
        public string? PictureId { get; set; }
        public string? MesaiPeriyodu { get; set; }
        public string UserId { get; set; } = null!;
        public string? CardId { get; set; }
        public int CardAttribute { get; set; }
        public int UserDef { get; set; }
        public bool? IlkGirisSonCikisAktif { get; set; }
        public bool? FabrikadaYemekYer { get; set; }
        public int? ServisGuzergahId { get; set; }
    }
}
