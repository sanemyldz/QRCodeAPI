using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblBilet
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public int? IzinTipId { get; set; }
        public string? Aciklama { get; set; }
        public DateTime? BiletAlisTarih { get; set; }
        public DateTime? UcusTarih { get; set; }
        public DateTime? DonusTarih { get; set; }
        public int? Ucret { get; set; }
        public int? UcretParaBirimi { get; set; }
        public string? DosyaYolu { get; set; }
    }
}
