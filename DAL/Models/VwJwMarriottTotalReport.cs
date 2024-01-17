using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwJwMarriottTotalReport
    {
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public DateTime GirisTarih { get; set; }
        public DateTime CikisTarih { get; set; }
        public string? BolumAdi { get; set; }
        public string? PozisyonAdi { get; set; }
        public string? FirmaAdi { get; set; }
        public int BolumId { get; set; }
        public int PozisyonId { get; set; }
        public int FirmaId { get; set; }
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
        public int IzinTip { get; set; }
        public int FazlaMesai { get; set; }
        public int FazlaMesaiOran { get; set; }
        public int EksikMesaiOran { get; set; }
        public int NormalMesai { get; set; }
        public int OnaylananFazlaMesai { get; set; }
        public string? MesaiAciklama { get; set; }
        public int IzinSaat { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public int Mesaibirimi { get; set; }
        public int MesaiSuresi { get; set; }
        public int MesaiPeriyodu { get; set; }
    }
}
