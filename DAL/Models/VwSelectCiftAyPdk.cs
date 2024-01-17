using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectCiftAyPdk
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? TcKimlikNo { get; set; }
        public int SicilId { get; set; }
        public string? BolumAdi { get; set; }
        public int? BolumId { get; set; }
        public string? FirmaAdi { get; set; }
        public int? FirmaId { get; set; }
        public string? GorevAdi { get; set; }
        public int? GorevId { get; set; }
        public int? PozisyonId { get; set; }
        public string? PozisyonAdi { get; set; }
        public string? BirimAdi { get; set; }
        public int? BirimId { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public int FazlaMesai { get; set; }
        public int GirisKayitTipi { get; set; }
        public string? MesaiKodu { get; set; }
        public string? MesaiAciklama { get; set; }
        public string IzinTipi { get; set; } = null!;
        public string? IzinKodu { get; set; }
    }
}
