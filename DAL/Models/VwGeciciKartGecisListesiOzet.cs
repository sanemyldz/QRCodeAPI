using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGeciciKartGecisListesiOzet
    {
        public int Id { get; set; }
        public string? SicilNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int BirimId { get; set; }
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int PozisyonId { get; set; }
        public int GorevId { get; set; }
        public string? FirmaAdi { get; set; }
        public string? BolumAdi { get; set; }
        public string? PozisyonAdi { get; set; }
        public string? GorevAdi { get; set; }
        public string? BirimAdi { get; set; }
        public string GeciciKartAdi { get; set; } = null!;
        public string GeciciKartNo { get; set; } = null!;
        public DateTime GeciciKartVerilmeTarih { get; set; }
        public DateTime GeciciKartIslemBitisTarihi { get; set; }
        public int GeciciKartSicilId { get; set; }
    }
}
