using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectSicilDetayRapor
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime GirisTarih { get; set; }
        public DateTime CikisTarih { get; set; }
        public string? SicilNo { get; set; }
        public string? Tckn { get; set; }
        public string GlobalSicilId { get; set; } = null!;
        public DateTime DogumTarih { get; set; }
        public int FirmaId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int StatuId { get; set; }
        public string StatuAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int BirimId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public DateTime SonGecerlilikTarihi { get; set; }
        public int AmirId { get; set; }
        public string AmirAdSoyad { get; set; } = null!;
        public bool FazlaMesai { get; set; }
        public string Cinsiyet { get; set; } = null!;
        public string DogumYeri { get; set; } = null!;
        public string AcilDurum { get; set; } = null!;
        public string AcilDurumTel { get; set; } = null!;
        public int SirketId { get; set; }
        public string SirketAdi { get; set; } = null!;
        public int TaseronFirmaId { get; set; }
        public string TaseronFirmaAdi { get; set; } = null!;
        public int Sgkid { get; set; }
        public string SgkAdi { get; set; } = null!;
        public string GorevTuru { get; set; } = null!;
        public string KanGrubu { get; set; } = null!;
        public string Egitim { get; set; } = null!;
        public int IsCikisNedeniId { get; set; }
        public string IsCikisNedeniAdi { get; set; } = null!;
        public int IsCikisNedeniSgk { get; set; }
        public string IsCikisNedeniSgkadi { get; set; } = null!;
        public string Telefon1 { get; set; } = null!;
        public string Telefon2 { get; set; } = null!;
        public string Adres { get; set; } = null!;
    }
}
