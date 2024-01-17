using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGirisCikisIhlalRaporu
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public DateTime MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public DateTime OglenGirisZamani { get; set; }
        public int GecGeldi { get; set; }
        public int ErkenCikti { get; set; }
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int GorevId { get; set; }
        public int PozisyonId { get; set; }
        public int BirimId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string BirimAdi { get; set; } = null!;
    }
}
