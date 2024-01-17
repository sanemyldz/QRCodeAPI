using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwNurdilGunlukMesaiDetay
    {
        public string SicilNo { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int MesaiSuresi { get; set; }
        public int NormalMesai { get; set; }
        public int FazlaMesai { get; set; }
        public int ErkenMesai { get; set; }
        public string Aciklama { get; set; } = null!;
        public int OnaylananFazlaMesai { get; set; }
        public string Izin { get; set; } = null!;
        public string ResmiTatil { get; set; } = null!;
        public int FazlamesaiOran { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public int BirimId { get; set; }
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int PozisyonId { get; set; }
        public int GorevId { get; set; }
    }
}
