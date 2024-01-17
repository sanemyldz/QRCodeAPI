using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectPersonelGirisCikisSure
    {
        public int Id { get; set; }
        public int? TasnifId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? TcNo { get; set; }
        public int SicilId { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public string? Okod1 { get; set; }
        public string MesaiAdi { get; set; } = null!;
        public bool? DinlenmeArasiKapsiyor { get; set; }
        public int? DinlenmeBaslangicFark { get; set; }
        public int? DinlenmeBitisFark { get; set; }
        public int? Sure { get; set; }
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
        public int GorevId { get; set; }
        public string? BirimAdi { get; set; }
        public int BirimId { get; set; }
        public int EnAzSure { get; set; }
        public int EncokSure { get; set; }
        public string? GlobalSicilId { get; set; }
        public int? Gorev { get; set; }
    }
}
