using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwPersonelHareketRaporu
    {
        public int TasnifId { get; set; }
        public int SicilId { get; set; }
        public DateTime IsBaslama { get; set; }
        public DateTime IsBitis { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public DateTime MesaiBas { get; set; }
        public DateTime MesaiBit { get; set; }
        public int MesaiToplamDinlenmeSuresi { get; set; }
        public string GecDurum { get; set; } = null!;
        public string ErkenDurum { get; set; } = null!;
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public int NormalMesai { get; set; }
        public int EksikCalisma { get; set; }
        public int IcerideKalmaSuresi { get; set; }
        public int MesaiSuresi { get; set; }
        public int ResmiTatil { get; set; }
        public string ResmiTatilAdi { get; set; } = null!;
        public int FazlaCalisma { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int Tatil { get; set; }
        public int? ErkenTolerans { get; set; }
        public int? GecTolerans { get; set; }
        public int IzinTip { get; set; }
        public string IzinAdi { get; set; } = null!;
        public string Kod { get; set; } = null!;
        public bool SaatlikIzin { get; set; }
        public DateTime IzinBaslangic { get; set; }
        public DateTime IzinBitis { get; set; }
        public decimal IzinGun { get; set; }
        public string Aciklama { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public DateTime GirisTarih { get; set; }
        public DateTime CikisTarih { get; set; }
        public string TcNo { get; set; } = null!;
        public string? PersonelKimlikNo { get; set; }
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
        public DateTime BaslangicTarih { get; set; }
        public DateTime BitisTarih { get; set; }
        public int UcretliIzinSure { get; set; }
        public int UcretsizIzinSure { get; set; }
        public int UserDef { get; set; }
        public bool Deleted { get; set; }
        public int? IzinIdList { get; set; }
        public bool ManuelDurum { get; set; }
    }
}
