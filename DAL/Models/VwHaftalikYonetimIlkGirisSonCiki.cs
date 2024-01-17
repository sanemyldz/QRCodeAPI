using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwHaftalikYonetimIlkGirisSonCiki
    {
        public int SicilId { get; set; }
        public string? SicilNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string FirmaAd { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAd { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAd { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string GorevAd { get; set; } = null!;
        public int GorevId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int GirisId { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int GecTolerans { get; set; }
        public int ErkenTolerans { get; set; }
        public int MesaiBas { get; set; }
        public int MesaiBit { get; set; }
        public int? Girilensaat { get; set; }
        public int? Cikilansaat { get; set; }
        public string GirisBilgisi { get; set; } = null!;
        public string CikisBilgisi { get; set; } = null!;
        public string? GirisStr { get; set; }
        public string? CikisStr { get; set; }
        public int BirimId { get; set; }
        public string? BirimAd { get; set; }
        public int Izintip { get; set; }
        public string? IzinAciklama { get; set; }
        public string Tatil { get; set; } = null!;
        public int ResmiTatil { get; set; }
        public string? ResmiTatilAdi { get; set; }
    }
}
