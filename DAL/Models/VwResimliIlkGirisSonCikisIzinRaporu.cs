using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwResimliIlkGirisSonCikisIzinRaporu
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public int? BirimId { get; set; }
        public int? FirmaId { get; set; }
        public int? BolumId { get; set; }
        public int? GorevId { get; set; }
        public int? PozisyonId { get; set; }
        public string? BirimAdi { get; set; }
        public string? FirmaAdi { get; set; }
        public string? BolumAdi { get; set; }
        public string? GorevAdi { get; set; }
        public string? PozisyonAdi { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public string? GirisResim { get; set; }
        public string? CikisResim { get; set; }
        public DateTime? IzinBaslangic { get; set; }
        public DateTime? IzinBitis { get; set; }
        public bool? Saatlikizin { get; set; }
        public string? IzinTipAdi { get; set; }
    }
}
