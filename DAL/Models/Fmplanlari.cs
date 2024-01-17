using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Fmplanlari
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public int CalisanSicilId { get; set; }
        public int? IzinliSicilId { get; set; }
        public int Fm { get; set; }
        public int FmnedenleriId { get; set; }
        public string? BelgeNo { get; set; }
        public int? SaatlikUcret { get; set; }
        public string? Aciklama { get; set; }

        public virtual Sicil CalisanSicil { get; set; } = null!;
        public virtual IzinTipleri Fmnedenleri { get; set; } = null!;
    }
}
