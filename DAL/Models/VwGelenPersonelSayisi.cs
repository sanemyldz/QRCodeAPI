using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGelenPersonelSayisi
    {
        public DateTime MesaiTarih { get; set; }
        public int PersonelSayisi { get; set; }
        public int PozisyonId { get; set; }
    }
}
