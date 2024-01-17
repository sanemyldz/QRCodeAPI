using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSaintGobainPersonelGunlukMesaiTakip
    {
        public int TasnifId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public int SicilId { get; set; }
        public DateTime IlkGiris { get; set; }
        public DateTime SonCikis { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public int GecSure { get; set; }
        public int ErkenSure { get; set; }
        public int EksikCalisma { get; set; }
        public int FazlaCalisma { get; set; }
        public int TotalIceridekiSure { get; set; }
        public int MesaiSuresi { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public int BirimId { get; set; }
        public int Gorev { get; set; }
        public int TatilDurumu { get; set; }
        public int ResmiTatil { get; set; }
        public int IzinSure { get; set; }
        public int? MesaiGiris { get; set; }
        public int? MesaiCikis { get; set; }
        public bool Tamgun { get; set; }
        public int? YarimGunTatilBaslangici { get; set; }
        public DateTime? Fmbaslangic { get; set; }
        public DateTime? Fmbitis { get; set; }
        public int? DinlenmeSure { get; set; }
    }
}
