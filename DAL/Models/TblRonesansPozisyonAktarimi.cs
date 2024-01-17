using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblRonesansPozisyonAktarimi
    {
        public int? Id { get; set; }
        public string? PozisyonAdi { get; set; }
        public string? BolumAdi { get; set; }
        public string? Statu { get; set; }
    }
}
