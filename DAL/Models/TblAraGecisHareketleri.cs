using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblAraGecisHareketleri
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public int? TasnifId { get; set; }
        public int? MesaiId { get; set; }
        public int? PoolGirisId { get; set; }
        public int? PoolCikisId { get; set; }
        public int? Sure { get; set; }
        public bool? DinlenmeArasiKapsiyor { get; set; }
        public int? DinlenmeBaslangicFark { get; set; }
        public int? DinlenmeBitisFark { get; set; }
        public int? CurrentBirimId { get; set; }
    }
}
