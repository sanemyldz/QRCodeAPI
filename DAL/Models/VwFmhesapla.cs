using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwFmhesapla
    {
        public int TasnifId { get; set; }
        public int SicilId { get; set; }
        public string SicilAdi { get; set; } = null!;
        public string Soyadi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public string? SicilNo { get; set; }
        public string? PersonelNo { get; set; }
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
        public int FazlaMesai { get; set; }
        public int MesaiSuresi { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int NormalMesai { get; set; }
        public int EnCokSure { get; set; }
        public int MesaiBas { get; set; }
        public int MesaiBit { get; set; }
        public int ErkenTolerans { get; set; }
        public int Gectolerans { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int GorevId { get; set; }
        public int PozisyonId { get; set; }
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int BirimId { get; set; }
    }
}
