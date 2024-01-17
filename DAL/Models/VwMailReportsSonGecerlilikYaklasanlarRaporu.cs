using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwMailReportsSonGecerlilikYaklasanlarRaporu
    {
        public int SicilId { get; set; }
        public int FirmaId { get; set; }
        public int BirimId { get; set; }
        public string? SicilNo { get; set; }
        public string? TcNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime SonGecerlilikTarihi { get; set; }
        public int? KalanGun { get; set; }
    }
}
