using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwStgArgePersonelBazliAraGeci
    {
        public DateTime? MesaiTarih { get; set; }
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime EventTime { get; set; }
        public int TerminalId { get; set; }
        public string TerminalAdi { get; set; } = null!;
        public int Io { get; set; }
        public int SicilId { get; set; }
        public string? Okod1 { get; set; }
        public string? Okod2 { get; set; }
        public string? Okod3 { get; set; }
        public string? Okod4 { get; set; }
        public string? Okod5 { get; set; }
        public string? SicilNo { get; set; }
        public string? PersonelNo { get; set; }
        public int BirimId { get; set; }
        public string? BirimAdi { get; set; }
        public int BolumId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public DateTime Giris { get; set; }
        public int GirisKayitTipi { get; set; }
        public DateTime? Cikis { get; set; }
        public int CikisKayitTipi { get; set; }
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
        public int? MesaiBas { get; set; }
        public int? MesaiBit { get; set; }
        public int? MaksGirisSapma { get; set; }
        public int? MaksCikisSapma { get; set; }
        public int? GecTolerans { get; set; }
        public int? ErkenTolerans { get; set; }
        public string? MesaiAciklama { get; set; }
        public int? MesaiIciDinlenmeSuresi { get; set; }
        public int? MesaiSuresi { get; set; }
    }
}
