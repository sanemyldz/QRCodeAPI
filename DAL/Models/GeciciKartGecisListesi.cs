using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class GeciciKartGecisListesi
    {
        public string Isim { get; set; } = null!;
        public string Soyisim { get; set; } = null!;
        public string Firma { get; set; } = null!;
        public string Bolum { get; set; } = null!;
        public string Pozisyon { get; set; } = null!;
        public string Gorev { get; set; } = null!;
        public string GeciciKartUserId { get; set; } = null!;
        public DateTime GeciciKartVerilmeTarih { get; set; }
        public DateTime GeciciKartIslemBitisTarihi { get; set; }
        public DateTime SonGecerlilikTarih { get; set; }
        public DateTime EventTime { get; set; }
        public string? Name { get; set; }
        public int TerminalId { get; set; }
        public int SicilId { get; set; }
        public int GeciciKartVerilenSicilId { get; set; }
        public int GeciciKartSicilId { get; set; }
        public string GeciciKartAd { get; set; } = null!;
        public string Yon { get; set; } = null!;
    }
}
