using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Sicil017
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int? Firma { get; set; }
        public int? TerminalGrubu { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? PersonelNo { get; set; }
        public DateTime? GirisTarih { get; set; }
        public DateTime? CikisTarih { get; set; }
        public string? SicilNo { get; set; }
        public int? Pozisyon { get; set; }
        public int? Bolum { get; set; }
        public string? Telefon1 { get; set; }
        public string? Telefon2 { get; set; }
        public string? CepTelefon { get; set; }
        public string? Adres { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public int? KanGrubu { get; set; }
        public byte[]? FotoImage { get; set; }
        public string? Bilgi { get; set; }
        public int MesaiPeriyodu { get; set; }
        public DateTime? PeriyodBaslangici { get; set; }
        public bool SonDurum { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool FazlaMesai { get; set; }
        public bool EksikMesai { get; set; }
        public bool EksikMesaiFm { get; set; }
        public bool ErkenMesai { get; set; }
        public bool EksikGun { get; set; }
        public int MaasTipi { get; set; }
        public int Maas { get; set; }
        public float AylikCalismaSaati { get; set; }
        public int SonTasnifId { get; set; }
        public byte? SicilKilit { get; set; }
        public DateTime? DogumTarih { get; set; }
        public string? Okod1 { get; set; }
        public string? Okod2 { get; set; }
        public string? Okod3 { get; set; }
        public string? Okod4 { get; set; }
        public string? Okod5 { get; set; }
        public string? Okod6 { get; set; }
        public string? Okod7 { get; set; }
        public string? Okod8 { get; set; }
        public string? Okod9 { get; set; }
        public string? Okod10 { get; set; }
        public bool GeceZammi { get; set; }
        public bool FmEm { get; set; }
        public int? Gorev { get; set; }
        public DateTime? Bitistarih { get; set; }
        public int? AltFirma { get; set; }
        public int? Cinsiyet { get; set; }
        public string? Email { get; set; }
        public int? Direktorluk { get; set; }
        public int? Yaka { get; set; }
        public int? Puantaj { get; set; }
        public DateTime? KidemTarih { get; set; }
        public int? BirimId { get; set; }
        public string? PictureId { get; set; }
        public bool? ZiyaretciKabulDurum { get; set; }
        public int? GorevId { get; set; }
        public bool Deleted { get; set; }
    }
}
