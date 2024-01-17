using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblOdaKalinanSureToplam
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int TasnifId { get; set; }
        public int OdaId { get; set; }
        public decimal ToplamSure { get; set; }
        public DateTime HesaplamaTarih { get; set; }
    }
}
