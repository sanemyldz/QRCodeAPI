using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwKartKullanmayanSicil
    {
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? PersonelNo { get; set; }
        public string? BolumAdi { get; set; }
        public string? FirmaAdi { get; set; }
        public string? BirimAdi { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int BirimId { get; set; }
        public int BolumId { get; set; }
        public int FirmaId { get; set; }
    }
}
