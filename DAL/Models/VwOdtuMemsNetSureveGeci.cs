using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwOdtuMemsNetSureveGeci
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? TcKimlikNo { get; set; }
        public DateTime MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public string? PozisyonAdi { get; set; }
        public string? BolumAdi { get; set; }
        public DateTime Zaman { get; set; }
        public string? TerminalAdi { get; set; }
        public int Yonu { get; set; }
        public string? Aciklama { get; set; }
        public int BolumId { get; set; }
        public int FirmaId { get; set; }
        public int TerminalId { get; set; }
        public int DinlenmeSure { get; set; }
        public int ToplamIceridekiSure { get; set; }
        public DateTime IzinBaslangic { get; set; }
        public DateTime IzinBitis { get; set; }
        public int ErkenCikma { get; set; }
        public int GecGelme { get; set; }
        public int EsikSure { get; set; }
        public int BirimId { get; set; }
        public int PozisyonId { get; set; }
        public int GorevId { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
    }
}
