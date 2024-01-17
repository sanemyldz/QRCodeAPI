using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwIcerdekiSure
    {
        public string? SicilNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public int BirimId { get; set; }
        public int SicilId { get; set; }
        public int TasniflemeId { get; set; }
        public DateTime GirisTarih { get; set; }
        public string Aciklama { get; set; } = null!;
        public DateTime MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int IcerdeBulunanSure { get; set; }
        public int MesaiSuresi { get; set; }
    }
}
