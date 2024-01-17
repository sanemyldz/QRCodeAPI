using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwOverTimeReportJw
    {
        public int Id { get; set; }
        public DateTime MesaiTarih { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? TcNo { get; set; }
        public int SicilId { get; set; }
        public int TotalIceridekiSure { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string? BirimAdi { get; set; }
        public int BirimId { get; set; }
        public DateTime IlkGiris { get; set; }
        public DateTime SonCikis { get; set; }
        public int Gorev { get; set; }
        public int TatilDurumu { get; set; }
        public int ToplamIzinSuresi { get; set; }
        public string? ResmiTatilAdi { get; set; }
        public int ResmiTatilId { get; set; }
        public string IzinDurumu { get; set; } = null!;
        public string? IzinKodu { get; set; }
        public int IzinTipId { get; set; }
        public int TotalDinlenmeSure { get; set; }
        public int MesaiDisiDinlenmeSuresi { get; set; }
        public int MesaiIciDinlenmeSuresi { get; set; }
        public int MesaiSuresi { get; set; }
    }
}
