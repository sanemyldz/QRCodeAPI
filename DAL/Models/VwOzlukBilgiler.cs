using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwOzlukBilgiler
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string PersonelNo { get; set; } = null!;
        public int BirimId { get; set; }
        public string BirimAd { get; set; } = null!;
        public int FirmaId { get; set; }
        public string FirmaAd { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAd { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAd { get; set; } = null!;
        public int BolumId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public string AnneAdi { get; set; } = null!;
        public string BabaAdi { get; set; } = null!;
        public string KanGrubuId { get; set; } = null!;
        public string KanGrubu { get; set; } = null!;
        public DateTime DogumTarihi { get; set; }
        public string DogumYeri { get; set; } = null!;
        public string KayitliIlId { get; set; } = null!;
        public string KayitliIl { get; set; } = null!;
        public string KayitliIlceId { get; set; } = null!;
        public string KayitliIlce { get; set; } = null!;
        public string KayitliMahalle { get; set; } = null!;
        public string MedeniHalId { get; set; } = null!;
        public string MedeniHal { get; set; } = null!;
        public string CinsiyetId { get; set; } = null!;
        public string Cinsiyet { get; set; } = null!;
        public string Askerlik { get; set; } = null!;
        public string Egitim { get; set; } = null!;
        public string CepTel { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string Adres { get; set; } = null!;
        public string Ehliyet { get; set; } = null!;
    }
}
