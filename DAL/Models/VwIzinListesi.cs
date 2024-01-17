using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwIzinListesi
    {
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public int BirimId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public int SicilId { get; set; }
        public bool Saatlik { get; set; }
        public int Id { get; set; }
        public string IzinAciklama { get; set; } = null!;
        public DateTime IzinBaslangic { get; set; }
        public DateTime IzinBitis { get; set; }
        public int IzinTipId { get; set; }
        public DateTime IseBaslamaTarih { get; set; }
        public string IzinTipAdi { get; set; } = null!;
        public DateTime IzinTarih { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string SicilNo { get; set; } = null!;
        public string TcKimlikNo { get; set; } = null!;
        public int UcretliIzinSure { get; set; }
        public int UcretsizIzinSure { get; set; }
        public decimal Gun { get; set; }
        public int Sure { get; set; }
    }
}
