using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwIzinliPersonelMail
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime BaslangicTarih { get; set; }
        public DateTime BitisTarih { get; set; }
        public string IzinTipAciklama { get; set; } = null!;
        public int TipId { get; set; }
        public int BolumId { get; set; }
        public int FirmaId { get; set; }
        public int PozisyonId { get; set; }
        public int BirimId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string BirimAdi { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAdi { get; set; } = null!;
    }
}
