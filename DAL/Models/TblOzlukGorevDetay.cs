using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblOzlukGorevDetay
    {
        public int Id { get; set; }
        public int? IkametId { get; set; }
        public int? SicilId { get; set; }
        public string? IsciStatu { get; set; }
        public string? MasrafMerkezUstKod { get; set; }
        public string? MasrafMerkezAltKod { get; set; }
        public string? MaaliyetMerkezi { get; set; }
        public string? UcretTipi { get; set; }
        public string? UcretOdeme { get; set; }
        public int? ResmiUcret { get; set; }
        public string? ResmiUcretParaBirimi { get; set; }
        public int? GayriResmiUcret { get; set; }
        public string? GayriResmiUcretParaBirimi { get; set; }
        public string? SirketTelefonHatti { get; set; }
        public string? PasaportNo { get; set; }
        public DateTime? PasaportBaslangicTarihi { get; set; }
        public DateTime? PasaportBitisTarihi { get; set; }
        public string? HarcirahHesaplansin { get; set; }
        public int? UcakBiletiHakki { get; set; }
        public int? IzinHakki { get; set; }
        public string? OturumIzniNo { get; set; }
        public DateTime? OturumIzniBaslangicTarihi { get; set; }
        public DateTime? OturumIzniBitisTarihi { get; set; }
        public string? CalismaIzniNo { get; set; }
        public DateTime? CalismaIzniBaslangicTarihi { get; set; }
        public DateTime? CalismaIzniBitisTarihi { get; set; }
        public string? KaldigiYer { get; set; }
        public string? GorevYeri { get; set; }
        public string? VizeYeri { get; set; }
        public int? VizeKategoriId { get; set; }
        public int? EkOdemeId { get; set; }
        public int? EkOdemeUcreti { get; set; }
        public string? EkOdemeParaBirimi { get; set; }
        public int? BilgilendirmeId { get; set; }
        public string? HarcirahTipi { get; set; }
        public int? HarcirahUcret { get; set; }
        public string? HarcirahParaBirimi { get; set; }
        public int? GercekKategoriId { get; set; }
        public int? SirketAracId { get; set; }
        public int? SirketCihazId { get; set; }
        public int? SirketBilgisayarId { get; set; }
        public int? SaglikRaporTipiId { get; set; }
        public DateTime? SaglikRaporBitisTarihi { get; set; }
        public DateTime? SaglikRaporBaslangicTarihi { get; set; }
        public int? Uyruk { get; set; }
        public int? IkinciUcret { get; set; }
        public string? IkinciUcretParaBirimi { get; set; }
    }
}
