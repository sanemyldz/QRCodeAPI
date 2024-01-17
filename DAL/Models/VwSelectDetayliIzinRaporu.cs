using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectDetayliIzinRaporu
    {
        public string? PersonelNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string Aciklama { get; set; } = null!;
        public int Sure { get; set; }
        public string SureTipi { get; set; } = null!;
        public DateTime BaslangicTarih { get; set; }
        public DateTime BitisTarih { get; set; }
        public int OnayDurum { get; set; }
        public bool IzinFormuVar { get; set; }
        public int BirimId { get; set; }
        public int SicilId { get; set; }
        public int BolumId { get; set; }
        public int GorevId { get; set; }
        public int PozisyonId { get; set; }
        public int FirmaId { get; set; }
        public int IzinTipId { get; set; }
        public string? SicilNo { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string? BirimAdi { get; set; }
    }
}
