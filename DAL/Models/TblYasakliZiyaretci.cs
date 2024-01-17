using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblYasakliZiyaretci
    {
        public int Id { get; set; }
        public string? ZiyaretciAd { get; set; }
        public string? ZiyaretciSoyad { get; set; }
        public string? ZiyaretciTcNo { get; set; }
        public int? IlkGeldigiRowId { get; set; }
        public int? SonGeldigiRowId { get; set; }
        public string? Aciklama { get; set; }
    }
}
