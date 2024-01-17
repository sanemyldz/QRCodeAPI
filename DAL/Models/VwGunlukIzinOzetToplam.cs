using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGunlukIzinOzetToplam
    {
        public int? Id { get; set; }
        public int? YillikIzin { get; set; }
        public int? DogumIzin { get; set; }
        public int? EvlilikIzin { get; set; }
        public int? OlumIzin { get; set; }
        public int? MazeretIzin { get; set; }
        public int? UcretsizIzinDevamsiz { get; set; }
        public int? UcretsizRaporluIzin { get; set; }
        public int? UcretliRaporluIzin { get; set; }
        public int? ToplamSure { get; set; }
    }
}
