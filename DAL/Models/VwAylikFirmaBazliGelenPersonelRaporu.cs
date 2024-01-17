using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAylikFirmaBazliGelenPersonelRaporu
    {
        public string? UniqueC { get; set; }
        public int SicilId { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public DateTime? BasTar { get; set; }
        public DateTime? BitTar { get; set; }
        public int? BirimId { get; set; }
        public string? BirimAdi { get; set; }
        public int? BolumId { get; set; }
        public int? FirmaId { get; set; }
        public string? FirmaAdi { get; set; }
        public int? PozisyonId { get; set; }
        public int? GorevId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? TcNo { get; set; }
        public string? SicilNo { get; set; }
    }
}
