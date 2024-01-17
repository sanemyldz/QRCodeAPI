using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwNurolSapaktarimRapor
    {
        public int SicilId { get; set; }
        public string? SicilNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? TcNo { get; set; }
        public int? FazlaCalisma { get; set; }
        public string UcretTuru { get; set; } = null!;
        public DateTime? GcrlBsl { get; set; }
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string? BirimAdi { get; set; }
        public int BirimId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
    }
}
