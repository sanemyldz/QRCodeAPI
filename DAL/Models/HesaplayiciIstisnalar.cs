using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HesaplayiciIstisnalar
    {
        public int Id { get; set; }
        public string IstisnaAdi { get; set; } = null!;
        public int? GerceklesenMesaiId { get; set; }
        public int? DayOfWeek { get; set; }
        public int? OncekiGunGerceklesenMesaiId { get; set; }
    }
}
