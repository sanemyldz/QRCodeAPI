using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class IzinlerLog
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int TipId { get; set; }
        public DateTime Tarih { get; set; }
        public bool Saatlikizin { get; set; }
        public string? Aciklama { get; set; }
        public int Sure { get; set; }
        public decimal? Gun { get; set; }
        public int Baslangic { get; set; }
        public int Bitis { get; set; }
        public bool Ucretli { get; set; }
        public int SaatlikUcret { get; set; }
        public int MailSended { get; set; }
        public DateTime? BasTarih { get; set; }
        public DateTime? BitTarih { get; set; }
        public string? KarsiAktarimIdTcSicil { get; set; }
        public int LoginUserId { get; set; }
        public int IslemTipId { get; set; }
        public DateTime IslemDatetime { get; set; }
        public int IzinId { get; set; }
        public DateTime? IseBaslamaTarih { get; set; }
        public int? OnayDurum { get; set; }
        public bool? IzinFormuVar { get; set; }
        public string? IzinTalepDosyasi { get; set; }
        public int? AnlikSira { get; set; }
    }
}
