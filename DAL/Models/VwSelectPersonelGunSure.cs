using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectPersonelGunSure
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public int SicilId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public string Okod1 { get; set; } = null!;
        public string MesaiAdi { get; set; } = null!;
        public int Sure { get; set; }
        public int Dinlenme { get; set; }
        public DateTime GirisZamani { get; set; }
        public DateTime CikisZamani { get; set; }
        public string GirisTerminali { get; set; } = null!;
        public string CikisTerminali { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int? GorevId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public int BirimId { get; set; }
        public int Gorev { get; set; }
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
    }
}
