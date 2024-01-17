using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwErkenCikanPersonel
    {
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public DateTime? Mbas { get; set; }
        public DateTime? Mbit { get; set; }
        public int Tolerans { get; set; }
        public int? CikisFark { get; set; }
        public string? BirimAdi { get; set; }
        public int? BirimKodu { get; set; }
    }
}
