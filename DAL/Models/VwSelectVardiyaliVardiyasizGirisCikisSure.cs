using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectVardiyaliVardiyasizGirisCikisSure
    {
        public DateTime? MesaiTarih { get; set; }
        public string Aciklama { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public int FazlaCalisma { get; set; }
        public int HataliGecis { get; set; }
        public int? TotalIceridekiSure { get; set; }
        public string GlobalSicilId { get; set; } = null!;
        public DateTime? IlkGiris { get; set; }
        public DateTime? SonCikis { get; set; }
    }
}
