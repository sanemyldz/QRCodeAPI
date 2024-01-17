﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAylikFazlaMesaiListesi
    {
        public string? SicilNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public int BirimId { get; set; }
        public int SicilId { get; set; }
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int TasniflemeId { get; set; }
        public int GorevId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public DateTime GirisTarih { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int OlmasiGerekenMesaiBas { get; set; }
        public int IcerdeBulunanSure { get; set; }
        public int MesaiSuresi { get; set; }
        public int GirisKayitTipi { get; set; }
        public int FazlaMesai { get; set; }
        public string MesaiAdi { get; set; } = null!;
        public string? YakaKodu { get; set; }
        public string? YakaTipi { get; set; }
        public int OnaylananFazlaMesai { get; set; }
    }
}
