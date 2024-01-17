using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Ziyaretci
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int Gorevli { get; set; }
        public string? Firma { get; set; }
        public string Ad { get; set; } = null!;
        public string? Soyad { get; set; }
        public int? KimlikTipi { get; set; }
        public string? KimlikNo { get; set; }
        public string? Kime { get; set; }
        public DateTime? Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public DateTime? Imza { get; set; }
        public string? Bilgi { get; set; }
        public int? SicilId1 { get; set; }
        public int? SicilId2 { get; set; }
        public int? SicilId3 { get; set; }
        public string? ZiyaretNedeni { get; set; }
        public string? Plaka { get; set; }
        public string? ResimId { get; set; }
        public int? RandevuId { get; set; }
        public int? BirimId { get; set; }
        public int? UserLokasyonId { get; set; }
        public string? DogumYeri { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? SurucuBelgeNo { get; set; }
        public string? RuhsatSeriNo { get; set; }
        public byte[]? KameraResim { get; set; }
        public string? Telefon { get; set; }
        public bool Deleted { get; set; }
        public string? HesCode { get; set; }
        public DateTime? IlkKartOkuma { get; set; }
        public DateTime? SonKartOkuma { get; set; }
        public string? IlkKartOkumaTerminal { get; set; }
        public string? SonKartOkumaTerminal { get; set; }
        public int? KurumFirmaId { get; set; }

        public virtual CboKimlik? KimlikTipiNavigation { get; set; }
    }
}
