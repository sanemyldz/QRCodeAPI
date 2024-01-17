using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilIzinKural
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int IzinkuralId { get; set; }

        public virtual TblIzinTanimKurali Izinkural { get; set; } = null!;
        public virtual Sicil Sicil { get; set; } = null!;
    }
}
