using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwNetsisAktarim
    {
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int Id { get; set; }
        public string? SicilNo { get; set; }
        public string? TcNo { get; set; }
        public DateTime Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public int FirmaId { get; set; }
        public string FirmaAd { get; set; } = null!;
        public int BolumId { get; set; }
        public string BolumAd { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAd { get; set; } = null!;
    }
}
