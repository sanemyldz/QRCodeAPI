using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Gorevlendirmeler
    {
        public int Id { get; set; }
        public int TipId { get; set; }
        public int SicilId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public int? DinlenmeSure { get; set; }
        public string? Aciklama { get; set; }
        public bool Deleted { get; set; }
        public int SonIslemYapanUserId { get; set; }
        public string? EntegrasyonKod { get; set; }
    }
}
