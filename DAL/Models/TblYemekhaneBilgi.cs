using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblYemekhaneBilgi
    {
        public TblYemekhaneBilgi()
        {
            TblSicilYemekhanes = new HashSet<TblSicilYemekhane>();
        }

        public int Id { get; set; }
        public string? Ad { get; set; }
        public bool? Aktif { get; set; }

        public virtual ICollection<TblSicilYemekhane> TblSicilYemekhanes { get; set; }
    }
}
