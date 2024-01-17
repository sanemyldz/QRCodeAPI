using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblOzlukKadro
    {
        public int Id { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public int SicilId { get; set; }
        public int KadroId { get; set; }
    }
}
