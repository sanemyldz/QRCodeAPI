using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwKafeteryaHakYuklemeRapor
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string? SicilNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? PersonelNo { get; set; }
        public int BolumId { get; set; }
        public int PozisyonId { get; set; }
        public int FirmaId { get; set; }
        public int GorevId { get; set; }
        public int BirimId { get; set; }
        public int? EklenenIcecekBakiye { get; set; }
        public int? EklenenYiyecekBakiye { get; set; }
        public int? IslemTur { get; set; }
        public DateTime? Tarih { get; set; }
    }
}
