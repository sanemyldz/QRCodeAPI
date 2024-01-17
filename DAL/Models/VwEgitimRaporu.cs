using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwEgitimRaporu
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string? EgitimTipi { get; set; }
        public string? FinansTipi { get; set; }
        public string? Organizator { get; set; }
        public string? Lokasyon { get; set; }
        public string? Aciklama { get; set; }
        public string? EgitimiVerenKurum { get; set; }
        public DateTime? BaslangicZamani { get; set; }
        public DateTime? BitisZamani { get; set; }
        public string? EgitmenAdi { get; set; }
        public string? SicilNo { get; set; }
        public string? SicilAd { get; set; }
        public string? SicilSoyad { get; set; }
        public string? PersonelNo { get; set; }
    }
}
