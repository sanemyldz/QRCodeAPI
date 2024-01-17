using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwVardiyasizMesaiOzet
    {
        public int Id { get; set; }
        public DateTime MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public int SicilId { get; set; }
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
        public string Okod1 { get; set; } = null!;
        public int Gorev { get; set; }
        public int TaseronFirmaId { get; set; }
        public string? TaseronFirmaAdi { get; set; }
        public int SirketId { get; set; }
        public string? SirketAdi { get; set; }
    }
}
