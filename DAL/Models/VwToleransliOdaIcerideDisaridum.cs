using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwToleransliOdaIcerideDisaridum
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string SicilNo { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime? MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int OdaId { get; set; }
        public string? OdaAdi { get; set; }
        public int? RaporTolerans { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string? BolumAdi { get; set; }
        public int? BolumId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public int BirimId { get; set; }
        public string? BirimAdi { get; set; }
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
    }
}
