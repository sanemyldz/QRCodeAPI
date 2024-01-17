using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwKisiBazliGunlukMesaiOzet
    {
        public int SicilId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public int BirimId { get; set; }
        public int Bolum { get; set; }
        public int Firma { get; set; }
        public int Pozisyon { get; set; }
        public int Gorev { get; set; }
        public DateTime IlkGiris { get; set; }
        public DateTime SonCikis { get; set; }
        public string? BirimAdi { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public int TotalIceridekiSure { get; set; }
        public string BolumAdi { get; set; } = null!;
    }
}
