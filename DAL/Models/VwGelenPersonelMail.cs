using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGelenPersonelMail
    {
        public int TasnifId { get; set; }
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int BirimId { get; set; }
        public int PozisyonId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public DateTime MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public string Aciklama { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAdi { get; set; } = null!;
    }
}
