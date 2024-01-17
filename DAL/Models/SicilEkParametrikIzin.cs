using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SicilEkParametrikIzin
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int IzinYil { get; set; }
        public int EkIzinGun { get; set; }
    }
}
