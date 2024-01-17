using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblAraGeci
    {
        public int Id { get; set; }
        public string? SicilId { get; set; }
        public DateTime? MesaiGunu { get; set; }
        public string? SicilNo { get; set; }
        public string? AdSoyad { get; set; }
        public string? GirisId { get; set; }
        public DateTime? Giris { get; set; }
        public string? GirisTerminalId { get; set; }
        public string? GirisTerminalAd { get; set; }
        public string? CikisId { get; set; }
        public DateTime? Cikis { get; set; }
        public string? CikisTerminalId { get; set; }
        public string? CikisTerminalAd { get; set; }
    }
}
