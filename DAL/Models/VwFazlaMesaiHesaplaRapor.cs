using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwFazlaMesaiHesaplaRapor
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime MesaiTarih { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public int SicilId { get; set; }
        public int BirimId { get; set; }
        public int FirmaId { get; set; }
        public string MesaiAdi { get; set; } = null!;
        public string? Tc { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int FazlaMesai { get; set; }
    }
}
