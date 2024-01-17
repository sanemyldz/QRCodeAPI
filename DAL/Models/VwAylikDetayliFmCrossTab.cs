using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAylikDetayliFmCrossTab
    {
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public int GorevId { get; set; }
        public int PozisyonId { get; set; }
        public int BolumId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int FazlaMesai { get; set; }
        public int ResmiTatil { get; set; }
        public int IzinTip { get; set; }
        public string? Kod { get; set; }
        public string? Aciklama { get; set; }
        public int BirimId { get; set; }
        public string? BirimAd { get; set; }
        public int IcerideKalmaSuresi { get; set; }
        public int MesaiSuresi { get; set; }
        public int ResmiTatilFazlaMesai { get; set; }
        public int MazeretIzniFazlaMesai { get; set; }
        public int IdariIzinFazlaMesai { get; set; }
        public int YillikIzinFazlaMesai { get; set; }
    }
}
