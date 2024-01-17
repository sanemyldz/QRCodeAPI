﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwMesaiHesaplamaKontrol
    {
        public int? GecisSayisi { get; set; }
        public int? AraGecisSayisi { get; set; }
        public int Id { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public string? Aciklama { get; set; }
        public int? MesaiId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? TcNo { get; set; }
        public int SicilId { get; set; }
        public int? EksikCalisma { get; set; }
        public int? ErkenCikti { get; set; }
        public int? FazlaCalisma { get; set; }
        public int? GecGeldi { get; set; }
        public int? HataliGecis { get; set; }
        public string? Ozet { get; set; }
        public int? TotalDinlenmeSure { get; set; }
        public int? TotalIceridekiSure { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string? BirimAdi { get; set; }
        public int BirimId { get; set; }
        public int? OglenCikisPoolId { get; set; }
        public int? OglenGirisPoolId { get; set; }
        public int? OglenMolaSure { get; set; }
        public DateTime? OglenCikisZamani { get; set; }
        public DateTime? OglenGirisZamani { get; set; }
        public string? OglenGirisTerminali { get; set; }
        public string? OglenCikisTerminali { get; set; }
        public string? MesaiOzetAciklama { get; set; }
        public string? OglenDurum { get; set; }
        public int? GlobalSicilId { get; set; }
        public DateTime? MesaiBasSonrasiIlkGiris { get; set; }
        public DateTime? MesaiBitOncesiSonCikis { get; set; }
        public DateTime? IlkGiris { get; set; }
        public DateTime? SonCikis { get; set; }
        public int TasnifId { get; set; }
    }
}
