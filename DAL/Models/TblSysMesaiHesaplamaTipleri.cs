using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSysMesaiHesaplamaTipleri
    {
        public int Id { get; set; }
        public string MesaiHesaplamaAdi { get; set; } = null!;
        public string MesaiHesaplamaAciklamalar { get; set; } = null!;
    }
}
