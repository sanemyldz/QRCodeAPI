using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwKisiBazliTumGirisCiki
    {
        public int SicilId { get; set; }
        public DateTime EventTime { get; set; }
        public DateTime MesaiTarih { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? PersonelNo { get; set; }
        public int BirimId { get; set; }
        public int Bolum { get; set; }
        public int Firma { get; set; }
        public int Pozisyon { get; set; }
        public int Gorev { get; set; }
        public string TerminalAdi { get; set; } = null!;
        public string GecisYonu { get; set; } = null!;
        public string? BirimAdi { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public int TerminalId { get; set; }
        public string BolumAdi { get; set; } = null!;
    }
}
