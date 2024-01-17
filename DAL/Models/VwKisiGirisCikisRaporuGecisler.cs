using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwKisiGirisCikisRaporuGecisler
    {
        public int TasnifId { get; set; }
        public int SicilId { get; set; }
        public DateTime IseBaslama { get; set; }
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
        public int EksikMesaiSuresi { get; set; }
        public int IcerideKalmaSuresi { get; set; }
        public int MesaiSuresi { get; set; }
        public int ResmiTatil { get; set; }
        public string ResmiTatilAdi { get; set; } = null!;
        public int FazlaMesai { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int Tatil { get; set; }
        public int? ErkenTolerans { get; set; }
        public int? GecTolerans { get; set; }
        public int IzinTip { get; set; }
        public string IzinAciklama { get; set; } = null!;
        public string IzinKodu { get; set; } = null!;
        public string MesaiAdi { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public DateTime GirisTarih { get; set; }
        public DateTime CikisTarih { get; set; }
        public string TcNo { get; set; } = null!;
        public string? TcKimlikNoNew { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string? BirimAdi { get; set; }
        public int BirimId { get; set; }
        public string LokasyonAdi { get; set; } = null!;
        public int LokasyonId { get; set; }
        public DateTime BasTarih { get; set; }
        public DateTime BitTarih { get; set; }
        public int UcretliIzinSuresi { get; set; }
        public int UcretsizIzinSuresi { get; set; }
        public int TerminalId { get; set; }
        public string TerminalAd { get; set; } = null!;
        public DateTime Zaman { get; set; }
    }
}
