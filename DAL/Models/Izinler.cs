using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Izinler
    {
        public Izinler()
        {
            TblIzinAkisSicilOnays = new HashSet<TblIzinAkisSicilOnay>();
        }

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
        public bool? Deleted { get; set; }
        public DateTime? IseBaslamaTarih { get; set; }
        public int? OnayDurum { get; set; }
        public bool? IzinFormuVar { get; set; }
        public string? IzinTalepDosyasi { get; set; }
        public int? AnlikSira { get; set; }
        public DateTime? GuncellemeZamani { get; set; }
        public int? TalepEdenUserId { get; set; }
        public bool? HakEdisOtele { get; set; }

        public virtual Sicil Sicil { get; set; } = null!;
        public virtual IzinTipleri Tip { get; set; } = null!;
        public virtual ICollection<TblIzinAkisSicilOnay> TblIzinAkisSicilOnays { get; set; }
    }
}
