using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectSicilOzlukRapor
    {
        public string? SgkSicilNo { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string? Tckn { get; set; }
        public DateTime IsBasiTarih { get; set; }
        public string? BirimAdi { get; set; }
        public string? EskiBirim { get; set; }
        public string? GorevYeri { get; set; }
        public string? HizmetGeciciGorev { get; set; }
        public string? HizmetKadro { get; set; }
        public string? FiiliGorev { get; set; }
        public string? SozlesmeTuru { get; set; }
        public string? Kadrosu { get; set; }
        public string? KadroDegisiklik { get; set; }
        public string? SendikaUnvani { get; set; }
        public string? EngelliEmekli { get; set; }
        public int EngelOrani { get; set; }
        public string? MeslekKodu { get; set; }
        public string? GorevAdi { get; set; }
        public string? UcretTipi { get; set; }
        public decimal BrutUcret { get; set; }
        public string? SendikaBilgisi { get; set; }
        public DateTime SendikaUyeBaslangicTarih { get; set; }
        public DateTime SendikaUyeBitisTarih { get; set; }
        public string? CikisNeden { get; set; }
        public string? GorevlendirildigiYer { get; set; }
        public string? GorevTarihi { get; set; }
        public string? Sertifika { get; set; }
        public string? Ehliyet { get; set; }
        public string EhliyetVeBelgeTarihi { get; set; } = null!;
        public string? YabanciDil { get; set; }
        public string? YabanciDilSeviye { get; set; }
        public string? Cezasi { get; set; }
        public string? Odul { get; set; }
        public string? VekaletBilgi { get; set; }
        public string? Adres { get; set; }
        public string? Ilce { get; set; }
        public string? CepTelefon { get; set; }
        public string? Eposta { get; set; }
        public string? KanGrubu { get; set; }
        public string? Cinsiyet { get; set; }
        public DateTime DogumTarih { get; set; }
        public string? DogumYeri { get; set; }
        public string? BabaAdi { get; set; }
        public string? NufusIli { get; set; }
        public string? MedeniDurum { get; set; }
        public string? EsiCalisyorMu { get; set; }
        public int CocukSayisi { get; set; }
        public string? Mezuniyet { get; set; }
        public string? MezunOlduguOkul { get; set; }
        public string? MezunOlduguBolum { get; set; }
        public string? MezunOlduguAlan { get; set; }
        public string? MezuniyetTarih { get; set; }
        public string? DiplomaNotu { get; set; }
        public string? AskerlikDurum { get; set; }
        public DateTime TecilTarih { get; set; }
        public string? Referans { get; set; }
    }
}
