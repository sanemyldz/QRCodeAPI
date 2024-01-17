using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TasniflemeSonEventList
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public DateTime? SonEventTime { get; set; }
        public int? OncekiGunGerceklesenMesaiId { get; set; }
    }
}
