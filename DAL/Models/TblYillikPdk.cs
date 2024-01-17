using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblYillikPdk
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int BirimId { get; set; }
        public int BolumId { get; set; }
        public int GorevId { get; set; }
        public int FirmaId { get; set; }
        public int PozisyonId { get; set; }
        public int YilNo { get; set; }
        public string? Ocak { get; set; }
        public string? Subat { get; set; }
        public string? Mart { get; set; }
        public string? Nisan { get; set; }
        public string? Mayis { get; set; }
        public string? Haziran { get; set; }
        public string? Temmuz { get; set; }
        public string? Agustos { get; set; }
        public string? Eylul { get; set; }
        public string? Ekim { get; set; }
        public string? Kasim { get; set; }
        public string? Aralik { get; set; }
        public string? Toplam { get; set; }
    }
}
