using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblMailHaftalik
    {
        public int Id { get; set; }
        public int? GunIndex { get; set; }
        public int? Hafta { get; set; }
        public DateTime? SonrakiHaftaTarih { get; set; }
        public DateTime? SonMailAtmaTarih { get; set; }
    }
}
