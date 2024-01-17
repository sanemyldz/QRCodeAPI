using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwPuantajDetayRapor
    {
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public int BolumId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int GunlukMesaiId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int MesaiId { get; set; }
        public DateTime IlkGiris { get; set; }
        public DateTime SonCikis { get; set; }
        public int NormalMesaiSuresi { get; set; }
        public int FazlaMesaiHesap { get; set; }
        public int EksikCalisma { get; set; }
        public int FazlaMesaiTasnifleme { get; set; }
        public int TatilDurumu { get; set; }
        public int? IzinId { get; set; }
        public int? UcretliIzinSure { get; set; }
        public int? UcretsizIzinSure { get; set; }
        public int? ToplamIzinSuresi { get; set; }
        public string? IzinIdList { get; set; }
        public int? ResmiTatlId { get; set; }
        public string? IzinDurumu { get; set; }
        public int ResmiTatilMesai { get; set; }
        public bool? Saatlikizin { get; set; }
        public bool? Ucretli { get; set; }
    }
}
