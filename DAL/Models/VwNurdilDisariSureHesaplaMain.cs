using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwNurdilDisariSureHesaplaMain
    {
        public DateTime EventTime { get; set; }
        public string Name { get; set; } = null!;
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int GirisId { get; set; }
        public DateTime CikisZamani { get; set; }
        public string CikisKapisi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string SicilNo { get; set; } = null!;
    }
}
