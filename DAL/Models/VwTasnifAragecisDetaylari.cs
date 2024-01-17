using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwTasnifAragecisDetaylari
    {
        public int Id { get; set; }
        public int TasnifId { get; set; }
        public DateTime IlkGiris { get; set; }
        public DateTime? SonCikis { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? TcNo { get; set; }
        public int SicilId { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public string? Okod1 { get; set; }
        public int NetMesaiSure { get; set; }
        public string MesaiAdi { get; set; } = null!;
        public bool? DinlenmeArasiKapsiyor { get; set; }
        public int? DinlenmeBaslangicFark { get; set; }
        public int? DinlenmeBitisFark { get; set; }
        public string? GerceklesenMesaiAdi { get; set; }
        public int GerceklesenNetMesaiSure { get; set; }
        public int? Sure { get; set; }
        public DateTime? GirisZamani { get; set; }
        public DateTime? CikisZamani { get; set; }
        public string? GirisTerminali { get; set; }
        public string? CikisTerminali { get; set; }
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
        public int EksikCalisma { get; set; }
        public int FazlaCalisma { get; set; }
        public int TotalDinlenmeSure { get; set; }
        public int TotalIceridekiSure { get; set; }
        public int OglenMolaSure { get; set; }
        public int? Gorev { get; set; }
        public string IzinIdList { get; set; } = null!;
        public int UcretliIzinSure { get; set; }
        public int UcretsizIzinSure { get; set; }
        public int TalepEdilenFmsure { get; set; }
        public string FazlaMesaiNedeni { get; set; } = null!;
        public int MesaiOncesiToplamIcerdekiSure { get; set; }
        public int MesaiDisiToplamIcerdekiSure { get; set; }
        public int MesaiBas { get; set; }
        public int MesaiBit { get; set; }
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
    }
}
