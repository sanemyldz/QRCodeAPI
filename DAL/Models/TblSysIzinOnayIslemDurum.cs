using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSysIzinOnayIslemDurum
    {
        public TblSysIzinOnayIslemDurum()
        {
            TblIzinAkisSicilOnays = new HashSet<TblIzinAkisSicilOnay>();
        }

        public int Id { get; set; }
        public string? IzinIslemDurumAdi { get; set; }

        public virtual ICollection<TblIzinAkisSicilOnay> TblIzinAkisSicilOnays { get; set; }
    }
}
