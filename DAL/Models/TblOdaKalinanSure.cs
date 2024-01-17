using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblOdaKalinanSure
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int OdaId { get; set; }
        public int TasnifId { get; set; }
        public int GirisPoolId { get; set; }
        public int CikisPoolId { get; set; }
        public decimal Sure { get; set; }
    }
}
