using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblPoolHataliGecisler
    {
        public int Id { get; set; }
        public int? PoolId1 { get; set; }
        public int? PoolId2 { get; set; }
        public int? SicilId { get; set; }
        public int? HataYonu { get; set; }
        public DateTime? HataInsertDate { get; set; }
        public bool? IslemYapildi { get; set; }
        public int? IslemPoolId { get; set; }
    }
}
