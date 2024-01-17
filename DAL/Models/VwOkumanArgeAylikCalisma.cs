using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwOkumanArgeAylikCalisma
    {
        public int TasnifId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int GunNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public int SicilId { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
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
        public int? IzinId { get; set; }
        public bool Ucretli { get; set; }
        public string IzinAdi { get; set; } = null!;
        public string IzinTipKodu { get; set; } = null!;
        public int IzinTipId { get; set; }
        public int IzinSureDk { get; set; }
        public decimal IzinSureGun { get; set; }
        public string MesaiAciklama { get; set; } = null!;
        public DateTime IlkGiris { get; set; }
        public DateTime SonCikis { get; set; }
        public string Okod1 { get; set; } = null!;
        public string Okod2 { get; set; } = null!;
        public string Okod3 { get; set; } = null!;
        public string Okod4 { get; set; } = null!;
        public string Okod5 { get; set; } = null!;
        public string Okod6 { get; set; } = null!;
        public int Gorev { get; set; }
        public int TatilDurumu { get; set; }
        public int ResmiTatil { get; set; }
        public int? ResmiTatilId { get; set; }
        public string? ResmiTatilKodu { get; set; }
        public string IzinDurumu { get; set; } = null!;
        public string IzinDetayAciklama { get; set; } = null!;
        public int UcretliSure { get; set; }
        public int UcretsizSure { get; set; }
        public bool Tamgun { get; set; }
    }
}
