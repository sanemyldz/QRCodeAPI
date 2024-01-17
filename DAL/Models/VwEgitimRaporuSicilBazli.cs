using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwEgitimRaporuSicilBazli
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
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
        public string SicilNo { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public int SicilId { get; set; }
        public int EgitimId { get; set; }
        public string EgitimAdi { get; set; } = null!;
        public string? EgitmenAdi { get; set; }
        public DateTime? BaslangicZamani { get; set; }
        public DateTime? BitisZamani { get; set; }
        public string? EgitimTipi { get; set; }
        public string? FinansTipi { get; set; }
        public string? Organizator { get; set; }
        public string? Lokasyon { get; set; }
        public string? Aciklama { get; set; }
        public string? EgitimiVerenKurum { get; set; }
    }
}
