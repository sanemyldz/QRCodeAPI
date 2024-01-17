using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwFazlaMesaiRaporuOstimOsb
    {
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? SicilId { get; set; }
        public string? TcNo { get; set; }
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
        public int? FazlaCalisma { get; set; }
        public DateTime MesaiTarih { get; set; }
        public string MesaiAdi { get; set; } = null!;
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
        public string? ResmiTatilAciklama { get; set; }
        public bool Rttamgun { get; set; }
        public int RtbasSaat { get; set; }
        public int MesaiBaslangic { get; set; }
        public int MesaiBitis { get; set; }
        public int Giris { get; set; }
        public int Cikis { get; set; }
    }
}
