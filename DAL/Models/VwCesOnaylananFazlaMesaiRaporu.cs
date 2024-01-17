using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwCesOnaylananFazlaMesaiRaporu
    {
        public string? SicilNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime? MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public int? OnaylananSure { get; set; }
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
        public string? Aciklama { get; set; }
        public int Id { get; set; }
        public int? BirimId { get; set; }
        public int SicilId { get; set; }
        public int? BolumId { get; set; }
        public int? FirmaId { get; set; }
        public int? GorevId { get; set; }
        public int? PozisyonId { get; set; }
        public string? TcNo { get; set; }
    }
}
