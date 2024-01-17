using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwCaniasPuantajAktarim
    {
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public int SicilId { get; set; }
        public string Aciklama { get; set; } = null!;
        public string BordroKodu { get; set; } = null!;
        public DateTime MesaiTarih { get; set; }
        public int MesaiSuresi { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int MesaiYili { get; set; }
        public int Donem { get; set; }
        public string MesaiKodu { get; set; } = null!;
        public int Gun { get; set; }
        public int EksikSaat { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public int IzinTip { get; set; }
        public int FirmaId { get; set; }
        public int PozisyonId { get; set; }
        public int BolumId { get; set; }
        public int Gorev { get; set; }
        public int BirimId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string BirimAdi { get; set; } = null!;
    }
}
