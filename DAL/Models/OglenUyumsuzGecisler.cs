using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class OglenUyumsuzGecisler
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public DateTime PeventTime { get; set; }
        public string PterminalAd { get; set; } = null!;
        public int TterminalIo { get; set; }
        public int TterminalPdks { get; set; }
        public int? FirmaId { get; set; }
        public int? BolumId { get; set; }
        public int? PozisyonId { get; set; }
        public int? BirimId { get; set; }
    }
}
