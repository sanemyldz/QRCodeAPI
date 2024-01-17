using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwDinamikGelmeyenPersonel
    {
        public int TasnifId { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public int SicilId { get; set; }
        public string? PersonelNo { get; set; }
        public string? SicilNo { get; set; }
        public string? BirimAdi { get; set; }
        public int? BirimKodu { get; set; }
        public string BolumAd { get; set; } = null!;
        public int BolumId { get; set; }
        public string GorevAd { get; set; } = null!;
        public int GorevId { get; set; }
        public string FirmaAd { get; set; } = null!;
        public int FirmaId { get; set; }
        public string PozisyonAd { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int? Firma { get; set; }
        public int? Bolum { get; set; }
        public int? Pozisyon { get; set; }
        public int? Gorev { get; set; }
        public string MesaiAciklama { get; set; } = null!;
        public int MesaiBas { get; set; }
        public int MesaiBit { get; set; }
    }
}
