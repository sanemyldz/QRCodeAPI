using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwKisiGirisCikisRaporu
    {
        public int TasnifId { get; set; }
        public int SicilId { get; set; }
        public DateTime IsBaslama { get; set; }
        public DateTime IsBitis { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public DateTime MesaiBaslangic { get; set; }
        public DateTime MesaiBitis { get; set; }
        public int MesaiToplamDinlenmeSuresi { get; set; }
        public int GecDurum { get; set; }
        public int ErkenDurum { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public int NormalMesai { get; set; }
        public int EksikCalisma { get; set; }
        public int IcerideKalmaSuresi { get; set; }
        public int MesaiSure { get; set; }
        public int ResmiTatil { get; set; }
        public string ResmiTatilAciklama { get; set; } = null!;
        public int FazlaMesai { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int Tatil { get; set; }
        public int? ErkenTolerans { get; set; }
        public int? GecTolerans { get; set; }
        public int IzinTip { get; set; }
        public string IzinAdi { get; set; } = null!;
        public string Kod { get; set; } = null!;
        public string Aciklama { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public DateTime GirisTar { get; set; }
        public DateTime CikisTar { get; set; }
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
        public DateTime BasTarih { get; set; }
        public DateTime BitTarih { get; set; }
        public int UcretliIzinSure { get; set; }
        public int UcretsizIzinSure { get; set; }
    }
}
