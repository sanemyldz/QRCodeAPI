using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectTanimsizMesaiOdaSure
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string? PersonelNo { get; set; }
        public DateTime GirisTarih { get; set; }
        public DateTime CikisTarih { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public decimal Sure { get; set; }
        public string? GirisTerminali { get; set; }
        public string? CikisTarminali { get; set; }
        public decimal ToplamSure { get; set; }
        public string? BolumAdi { get; set; }
        public int BolumId { get; set; }
        public string? PozisyonAdi { get; set; }
        public int PozisyonId { get; set; }
        public string? FirmaAdi { get; set; }
        public int FirmaId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public int BirimId { get; set; }
        public string? OdaAdi { get; set; }
        public int OdaId { get; set; }
        public string Okod1 { get; set; } = null!;
        public string? GorevAdi { get; set; }
    }
}
