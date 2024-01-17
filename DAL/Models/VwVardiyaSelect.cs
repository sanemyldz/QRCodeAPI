using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwVardiyaSelect
    {
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int? MesaiId { get; set; }
        public int? BirimKodu { get; set; }
        public string? SicilNo { get; set; }
        public DateTime? CikisTarih { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string? BirimAdi { get; set; }
        public int BirimId { get; set; }
        public string? Aciklama { get; set; }
        public string? MesaiAdi { get; set; }
        public string? PersonelNo { get; set; }
    }
}
