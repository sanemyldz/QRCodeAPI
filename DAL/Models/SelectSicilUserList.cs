using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SelectSicilUserList
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string PersonelNo { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime GirisTarih { get; set; }
        public int? AmirId { get; set; }
        public DateTime? CikisTarih { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public int? BirimKodu { get; set; }
        public string BirimAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public int PozisyonId { get; set; }
        public int? GorevId { get; set; }
        public int BolumId { get; set; }
        public bool Deleted { get; set; }
        public string? Telefon1 { get; set; }
        public string? CepTelefon { get; set; }
        public string? Adres { get; set; }
        public string? Okod1 { get; set; }
        public string? Okod2 { get; set; }
        public string? Okod3 { get; set; }
        public string? Okod4 { get; set; }
        public string? Okod5 { get; set; }
        public string? Okod6 { get; set; }
        public string? Bilgi { get; set; }
        public int? BirimId { get; set; }
        public bool FazlaMesai { get; set; }
        public string? AmirAdi { get; set; }
        public DateTime ExpireDate { get; set; }
        public string? PictureId { get; set; }
        public string? MesaiPeriyodu { get; set; }
        public string UserId { get; set; } = null!;
        public string? CardId { get; set; }
        public int CardAttribute { get; set; }
        public int UserDef { get; set; }
        public bool? IlkGirisSonCikisAktif { get; set; }
        public bool? FabrikadaYemekYer { get; set; }
        public int? ServisGuzergahId { get; set; }
        public string TaseronFirmaAdi { get; set; } = null!;
        public int TaseronFirmaId { get; set; }
        public string AcilDurumIrtibatKisisi { get; set; } = null!;
        public string AcilDurumIrtibatKisisiEvTel { get; set; } = null!;
        public string AcilDurumIrtibatKisisiIsTel { get; set; } = null!;
        public int SgkDurum { get; set; }
        public string IstenAyrilisNedeni { get; set; } = null!;
        public int YakaTipi { get; set; }
        public string Iban { get; set; } = null!;
        public string? HesCode { get; set; }
        public DateTime? DogumTarih { get; set; }
        public string? MesaiAdi { get; set; }
        public string? Email { get; set; }
        public string KanGrubu { get; set; } = null!;
        public string FacilityCode { get; set; } = null!;
    }
}
