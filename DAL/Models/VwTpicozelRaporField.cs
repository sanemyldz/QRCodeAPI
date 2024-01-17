using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwTpicozelRaporField
    {
        public int SicilId { get; set; }
        public int SiraNo { get; set; }
        public string SicilNo { get; set; } = null!;
        public string Tcno { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string Pozisyon { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string Bolum { get; set; } = null!;
        public int BolumId { get; set; }
        public string Firma { get; set; } = null!;
        public int FirmaId { get; set; }
        public int GorevId { get; set; }
        public string Gorev { get; set; } = null!;
        public int BirimId { get; set; }
        public string Birim { get; set; } = null!;
        public DateTime MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public string IzinAciklama { get; set; } = null!;
        public int FazlaCalisma { get; set; }
        public int EksikCalisma { get; set; }
        public int YemekSuresi { get; set; }
        public int CalismaSuresi { get; set; }
        public int NormalMesaiSuresi { get; set; }
    }
}
