using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectGunlukMesaiOzetGerceklesenMesai
    {
        public int Id { get; set; }
        public DateTime MesaiTarih { get; set; }
        public string TanimliMesai { get; set; } = null!;
        public string GerceklesenMesai { get; set; } = null!;
        public int MesaiId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public int SicilId { get; set; }
        public int EksikCalisma { get; set; }
        public int ErkenCikti { get; set; }
        public int FazlaCalisma { get; set; }
        public int GecGeldi { get; set; }
        public int HataliGecis { get; set; }
        public string Ozet { get; set; } = null!;
        public int TotalDinlenmeSure { get; set; }
        public int TotalIceridekiSure { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public int BirimId { get; set; }
        public int OglenCikisPoolId { get; set; }
        public int OglenGirisPoolId { get; set; }
        public int OglenMolaSure { get; set; }
        public string MesaiOzetAciklama { get; set; } = null!;
        public DateTime IlkGiris { get; set; }
        public DateTime SonCikis { get; set; }
        public int TasnifId { get; set; }
        public string Okod1 { get; set; } = null!;
        public int Gorev { get; set; }
        public int TatilDurumu { get; set; }
        public string IzinDurumu { get; set; } = null!;
    }
}
