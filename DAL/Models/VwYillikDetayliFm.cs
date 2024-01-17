using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwYillikDetayliFm
    {
        public int SicilId { get; set; }
        public int Id { get; set; }
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
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public DateTime GirisTarih { get; set; }
        public DateTime CikisTarih { get; set; }
        public string? TcNo { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string? BirimAdi { get; set; }
        public int BirimId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public int ResmiTatilFm { get; set; }
    }
}
