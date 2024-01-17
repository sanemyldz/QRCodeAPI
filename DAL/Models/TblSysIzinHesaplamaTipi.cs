using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSysIzinHesaplamaTipi
    {
        public TblSysIzinHesaplamaTipi()
        {
            TblIzinTanimKuralis = new HashSet<TblIzinTanimKurali>();
        }

        public int Id { get; set; }
        public int HesapKod { get; set; }
        public string HesaplamaTipAdi { get; set; } = null!;

        public virtual ICollection<TblIzinTanimKurali> TblIzinTanimKuralis { get; set; }
    }
}
