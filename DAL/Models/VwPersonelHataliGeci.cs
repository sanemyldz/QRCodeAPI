using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwPersonelHataliGeci
    {
        public int Id { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public string? Aciklama { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? TcNo { get; set; }
        public int SicilId { get; set; }
        public string HataliGecisYonu { get; set; } = null!;
        public int HataliSure { get; set; }
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
        public DateTime? Pgiris { get; set; }
        public DateTime? PgirisIki { get; set; }
        public DateTime? Pcikis { get; set; }
        public DateTime? PcikisIki { get; set; }
    }
}
