using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectSicilIzinKural
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? TcNo { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public DateTime? GirisTarih { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string? BirimAdi { get; set; }
        public int BirimId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public string? KuralAdi { get; set; }
        public int? KuralId { get; set; }
        public decimal? ToplamKalanIzinGun { get; set; }
        public int? ToplamKalanIzinSaat { get; set; }
        public decimal? ToplamKullanilanIzinGun { get; set; }
        public int? ToplamKullanilanIzinSaat { get; set; }
        public decimal? ToplamHakEdilenIzinGun { get; set; }
        public int? ToplamHakEdilenIzinSaat { get; set; }
    }
}
