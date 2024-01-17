using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAylikDetayliPdk
    {
        public int Id { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int MesaiSuresi { get; set; }
        public int IceridekiSure { get; set; }
        public int Dinlenme { get; set; }
        public int FazlaCalisma { get; set; }
        public int EksikCalisma { get; set; }
        public int GecGeldi { get; set; }
        public int ErkenCikti { get; set; }
        public int GeceDinlenmeCalismaSure { get; set; }
        public int GeceDinlenmeToplamSure { get; set; }
        public int GeceFazlaMesai { get; set; }
        public int GeceMesaiSure { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int ResmiTatil { get; set; }
        public int Tatil { get; set; }
        public decimal OdaSure { get; set; }
        public int OdaId { get; set; }
        public int SicilId { get; set; }
        public int BirimId { get; set; }
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int GorevId { get; set; }
        public int PozisyonId { get; set; }
        public string SicilNo { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string BirimAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public int YurtIciGorev { get; set; }
        public int YurtDisiGorev { get; set; }
        public int YillikIzin { get; set; }
        public int DogumIzin { get; set; }
        public int EvlilikIzin { get; set; }
        public int OlumIzin { get; set; }
        public int MazeretIzin { get; set; }
        public int SendikaIzin { get; set; }
        public int CovidIzin { get; set; }
        public int Sgkraporlu { get; set; }
        public int IsyeriHekim { get; set; }
        public int SgkraporSendika { get; set; }
        public int UcretsizIzinDevamsiz { get; set; }
        public int Pdü { get; set; }
        public string Mesai { get; set; } = null!;
    }
}
