using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwHaftalikTseeksikCalisma
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int BirimId { get; set; }
        public string? BirimAdi { get; set; }
        public string? SicilNo { get; set; }
        public string? Aciklama { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public DateTime MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int? Dinlenme { get; set; }
        public int? GecKalma { get; set; }
        public int CalisilanSure { get; set; }
        public int HaftaIciFazlaMesai { get; set; }
        public int HaftaSonuFazlaMesai { get; set; }
        public int? EksikCalisma { get; set; }
        public int? Izin { get; set; }
        public int BolumId { get; set; }
        public string BolumAd { get; set; } = null!;
        public string FirmaAd { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public string PozisyonAd { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public int Tolerans { get; set; }
        public int FirmaId { get; set; }
        public int? GecTolerans { get; set; }
        public int? ErkenTolerans { get; set; }
    }
}
