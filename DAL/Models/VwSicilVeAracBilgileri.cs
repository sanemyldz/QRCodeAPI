using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSicilVeAracBilgileri
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string? PersonelNo { get; set; }
        public string? SicilNo { get; set; }
        public string Soyad { get; set; } = null!;
        public DateTime GirisTarih { get; set; }
        public int AmirId { get; set; }
        public DateTime CikisTarih { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string? GorevAdi { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int BirimKodu { get; set; }
        public string? BirimAdi { get; set; }
        public int FirmaId { get; set; }
        public int PozisyonId { get; set; }
        public int GorevId { get; set; }
        public int BolumId { get; set; }
        public bool Deleted { get; set; }
        public string? Telefon1 { get; set; }
        public string? CepTelefon { get; set; }
        public string? Adres { get; set; }
        public int BirimId { get; set; }
        public string? TaseronFirmaAdi { get; set; }
        public string? AracPlaka { get; set; }
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public string? RuhsatNo { get; set; }
        public int? AracId { get; set; }
        public int? AracSicilId { get; set; }
        public string UserId { get; set; } = null!;
        public int TaseronFirmaId { get; set; }
    }
}
