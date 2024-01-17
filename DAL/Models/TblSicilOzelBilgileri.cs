using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilOzelBilgileri
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string? EvlilikDurumu { get; set; }
        public DateTime? EvlilikTarihi { get; set; }
        public int? CocukSayisi { get; set; }
        public string? AiledekiEngelliKisi { get; set; }
        public int? EngelliOranı { get; set; }
        public bool SabikaDurumu { get; set; }
        public string? SabikaNedeni { get; set; }
        public bool OzurDurumu { get; set; }
        public string? OzurHali { get; set; }
        public int? OzurOrani { get; set; }
        public bool KalitsalHastalik { get; set; }
        public string? KalitsalHastalikTanisi { get; set; }
    }
}
