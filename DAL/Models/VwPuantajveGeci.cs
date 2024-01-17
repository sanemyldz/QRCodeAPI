using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwPuantajveGeci
    {
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public int BirimId { get; set; }
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int GorevId { get; set; }
        public int PozisyonId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int GirisKayitTipi { get; set; }
        public DateTime Giris { get; set; }
        public int CikisKayitTipi { get; set; }
        public DateTime Cikis { get; set; }
        public int MesaiSuresiDk { get; set; }
        public int FazlaCalisma { get; set; }
        public int TotalIceridekiSure { get; set; }
        public int DinlenmeSure { get; set; }
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
        public int IzinId { get; set; }
        public int IzinTip { get; set; }
        public string IzinTipAciklama { get; set; } = null!;
        public string BirimAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public int EksikCalisma { get; set; }
        public int GecGeldi { get; set; }
        public int ErkenCikti { get; set; }
        public string IzinAciklama { get; set; } = null!;
        public bool Saatlikizin { get; set; }
        public DateTime BaslangicTarih { get; set; }
        public DateTime BitisTarih { get; set; }
        public string Okod4 { get; set; } = null!;
        public string Okod5 { get; set; } = null!;
        public decimal IzinGun { get; set; }
        public int UcretliIzinSure { get; set; }
        public int UcretsizIzinSure { get; set; }
        public DateTime EventTime { get; set; }
        public int TerminalId { get; set; }
        public string TerminalAdi { get; set; } = null!;
        public string Yon { get; set; } = null!;
        public int YonId { get; set; }
        public int PoolId { get; set; }
        public int MesaiBaslangic { get; set; }
        public int MesaiBitis { get; set; }
    }
}
