using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SelectIzinSuresiRaporu2
    {
        public string? SicilNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public string? PersonelNo { get; set; }
        public DateTime? GirisTarih { get; set; }
        public string? BirimAdi { get; set; }
        public int MesaiSuresi { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public int HamSure { get; set; }
        public int ToplamMesaiSure { get; set; }
        public int CalismaSuresiIleMesaiSuresiFarki { get; set; }
        public string IzinKodu { get; set; } = null!;
        public int GorevSuresi { get; set; }
        public int YillikIzinSuresi { get; set; }
        public int SihhiIsBasi { get; set; }
        public int DigerIzinler { get; set; }
        public int UcretsizIzinler { get; set; }
        public int MazeretIzni { get; set; }
        public int SihhiRapor { get; set; }
        public int SaatlikGorevIzni { get; set; }
        public int SicilId { get; set; }
        public int BirimId { get; set; }
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int GorevId { get; set; }
        public int PozisyonId { get; set; }
        public int ResmiTatil { get; set; }
        public int Tatil { get; set; }
        public DateTime CikisTarih { get; set; }
    }
}
