using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblMolaHesapTablosu
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public DateTime? Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public int? MolaSure { get; set; }
        public int? MolaSayi { get; set; }
        public int? HataliSayi { get; set; }
        public int? IzinTipId { get; set; }
        public int? ResmiTatilId { get; set; }
        public DateTime? OglenBaslangic { get; set; }
        public DateTime? OglenBitis { get; set; }
        public int? TotalMolaSure { get; set; }
        public int? TotalMolaSayi { get; set; }
    }
}
