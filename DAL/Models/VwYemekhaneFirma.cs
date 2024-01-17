using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwYemekhaneFirma
    {
        public int FirmaId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public int Sayi { get; set; }
        public int OgunId { get; set; }
        public string OgunAdi { get; set; } = null!;
        public int OgunBaslangic { get; set; }
        public int OgunBitis { get; set; }
    }
}
