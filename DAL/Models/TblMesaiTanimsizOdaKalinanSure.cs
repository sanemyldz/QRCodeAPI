using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblMesaiTanimsizOdaKalinanSure
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int OdaId { get; set; }
        public DateTime Tarih { get; set; }
        public int PoolGirisId { get; set; }
        public int PoolCikisId { get; set; }
        public decimal Sure { get; set; }
        public decimal ToplamSure { get; set; }
        public int? CurrentBirimId { get; set; }
    }
}
