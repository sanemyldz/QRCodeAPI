using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwBastugSapAktarimCsv
    {
        public string? SicilNo { get; set; }
        public string? Tarih { get; set; }
        public string? Saat { get; set; }
        public string Yon { get; set; } = null!;
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
        public DateTime? MesaiTarih { get; set; }
        public int SicilId { get; set; }
        public int Kayittipi { get; set; }
    }
}
