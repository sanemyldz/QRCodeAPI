using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblIzinAkisSicil
    {
        public int Id { get; set; }
        public int IzinAkisId { get; set; }
        public int SiraNo { get; set; }
        public int SicilId { get; set; }
    }
}
