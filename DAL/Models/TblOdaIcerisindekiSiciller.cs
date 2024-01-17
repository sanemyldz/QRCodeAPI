using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblOdaIcerisindekiSiciller
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public int? OdaId { get; set; }
        public int? PoolGirisId { get; set; }
    }
}
