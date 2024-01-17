using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwKafeteryaRaporuSatislar
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? PersonelNo { get; set; }
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int PozisyonId { get; set; }
        public int GorevId { get; set; }
        public int BirimId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public string? UrunAdi { get; set; }
        public int UrunTurId { get; set; }
        public int? UrunKategoriId { get; set; }
        public byte SatisTip { get; set; }
        public int YakaTipId { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal YiyecekBakiye { get; set; }
        public decimal IcecekBakiye { get; set; }
        public bool? MesaiDisi { get; set; }
        public bool? Onaylandi { get; set; }
        public DateTime SiparisTarih { get; set; }
    }
}
