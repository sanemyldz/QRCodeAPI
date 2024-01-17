using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwNurdilDisariSureHesaplaWc
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public int GirisId { get; set; }
        public DateTime CikisZamani { get; set; }
        public string CikisKapisi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int Mesaibirimi { get; set; }
        public string Aciklama { get; set; } = null!;
        public int Io { get; set; }
        public int Kind { get; set; }
    }
}
