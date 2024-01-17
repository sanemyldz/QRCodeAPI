using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblHataliGecisler
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int TasnifId { get; set; }
        public int PoolGirisId { get; set; }
        public int PoolGirisIkinciId { get; set; }
        public int PoolCikisId { get; set; }
        public int PoolCikisIkinciId { get; set; }
        public string HataliGecisYonu { get; set; } = null!;
        public int HataliSure { get; set; }
    }
}
