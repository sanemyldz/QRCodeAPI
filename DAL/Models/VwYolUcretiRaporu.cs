using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwYolUcretiRaporu
    {
        public string? SicilNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int BolumId { get; set; }
        public int FirmaId { get; set; }
        public DateTime Tarih { get; set; }
        public byte Yon { get; set; }
        public int Adet { get; set; }
        public decimal YolUcret { get; set; }
        public decimal DonusYolUcret { get; set; }
        public decimal Toplam { get; set; }
        public string MesaiAciklama { get; set; } = null!;
        public int MesaiSuresi { get; set; }
    }
}
