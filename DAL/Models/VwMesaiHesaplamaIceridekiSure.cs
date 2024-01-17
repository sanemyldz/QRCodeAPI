using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwMesaiHesaplamaIceridekiSure
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime MesaiTarih { get; set; }
        public string GerceklesenMesai { get; set; } = null!;
        public int MesaiId { get; set; }
        public int SicilId { get; set; }
        public int? CalismaDurumu { get; set; }
        public int TotalIceridekiSure { get; set; }
        public int TasnifId { get; set; }
    }
}
