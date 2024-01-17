﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwIomistanbulHavalimaniPuantaj
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int BirimId { get; set; }
        public string? BirimAdi { get; set; }
        public string? SicilNo { get; set; }
        public string? Aciklama { get; set; }
        public string? PersonelNo { get; set; }
        public DateTime Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int BolumId { get; set; }
        public string BolumAd { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
    }
}
