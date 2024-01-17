using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblZiyaretciSearchParam
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? ZiyaretciAd { get; set; }
        public string? ZiyaretciSoyad { get; set; }
        public string? ZiyaretciTcNo { get; set; }
        public string? ZiyaretciPlaka { get; set; }
        public DateTime? BasTar { get; set; }
        public DateTime? SonTar { get; set; }
        public DateTime? TekTar { get; set; }
        public string? Firma { get; set; }
        public string? Lokasyon { get; set; }
        public string? Sicil1 { get; set; }
        public string? Sicil2 { get; set; }
        public string? Aciklamalar { get; set; }
        public string? HesCode { get; set; }
        public string? ZiyaretciKartInfo { get; set; }
        public string? KartNo { get; set; }
    }
}
