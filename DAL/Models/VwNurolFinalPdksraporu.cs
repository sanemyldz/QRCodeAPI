using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwNurolFinalPdksraporu
    {
        public int TasnifId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public string? Devamsiz { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public int SicilId { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public int TotalDinlenmeSure { get; set; }
        public int TotalIceridekiSure { get; set; }
        public int MesaiSuresi { get; set; }
        public int GecTolerans { get; set; }
        public int ErkenTolerans { get; set; }
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int PozisyonId { get; set; }
        public int GorevId { get; set; }
        public int BirimId { get; set; }
        public int? IzinId { get; set; }
        public bool Ucretli { get; set; }
        public string IzinAdi { get; set; } = null!;
        public string IzinTipKodu { get; set; } = null!;
        public int IzinTipId { get; set; }
        public int IzinSureDk { get; set; }
        public decimal IzinSureGun { get; set; }
        public string MesaiAciklama { get; set; } = null!;
        public int TatilDurumu { get; set; }
        public int ResmiTatil { get; set; }
        public int? ResmiTatilId { get; set; }
        public string? ResmiTatilKodu { get; set; }
        public string IzinDetayAciklama { get; set; } = null!;
        public int UcretliSure { get; set; }
        public int UcretsizSure { get; set; }
        public decimal OdaKalinanSure { get; set; }
    }
}
