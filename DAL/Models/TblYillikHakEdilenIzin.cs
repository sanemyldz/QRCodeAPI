using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblYillikHakEdilenIzin
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int YillikHakEdilenGun { get; set; }
        public DateTime HakEdilenTarih { get; set; }
    }
}
