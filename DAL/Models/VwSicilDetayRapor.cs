using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSicilDetayRapor
    {
        public string? CardId { get; set; }
        public bool? Secili { get; set; }
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string AmirAdi { get; set; } = null!;
        public string LokasyonAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public int? FirmaId { get; set; }
        public int LokasyonId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int? BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int? PozisyonId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int? GorevId { get; set; }
        public string? BirimAdi { get; set; }
        public string? Tcno { get; set; }
        public string? SicilNo { get; set; }
        public string? Adres { get; set; }
        public string? TelefonNo { get; set; }
        public string? TelefonNo2 { get; set; }
        public string? UserId { get; set; }
        public int CardDef { get; set; }
        public DateTime? IseBaslama { get; set; }
        public DateTime? IstenAyrilma { get; set; }
        public string IseBaslamaString { get; set; } = null!;
        public string IstenAyrilmaString { get; set; } = null!;
        public string SicilInfo { get; set; } = null!;
        public int? BirimId { get; set; }
        public string MesaiPeriyodu { get; set; } = null!;
        public string? Okod1 { get; set; }
        public string? Okod2 { get; set; }
        public string? Okod3 { get; set; }
        public string? Okod4 { get; set; }
        public string? Okod5 { get; set; }
        public string? Okod6 { get; set; }
        public string? Okod7 { get; set; }
        public string? Okod8 { get; set; }
        public string? Bilgi { get; set; }
        public int SgkDurum { get; set; }
        public string? IstenAyrilisNedeni { get; set; }
        public int YakaTipi { get; set; }
        public string? Iban { get; set; }
        public string? AcilDurumIrtibatKisisi { get; set; }
        public string? AcilDurumIrtibatKisisiEvTel { get; set; }
        public string? AcilDurumIrtibatKisisiIsTel { get; set; }
        public DateTime GecerlilikSuresi { get; set; }
        public DateTime ExpireDate { get; set; }
        public string? PictureId { get; set; }
        public int SicilId { get; set; }
        public bool Deleted { get; set; }
    }
}
