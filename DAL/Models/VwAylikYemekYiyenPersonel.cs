using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAylikYemekYiyenPersonel
    {
        public DateTime Tarih { get; set; }
        public string Departman { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string? SicilNo { get; set; }
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int Mesaibirimi { get; set; }
        public string Aciklama { get; set; } = null!;
        public string YemekhaneNumarasi { get; set; } = null!;
        public int DepartmanId { get; set; }
        public int BolumId { get; set; }
        public int MesaiPeriodId { get; set; }
        public int YemekhaneBilgiId { get; set; }
        public int TerminalId { get; set; }
        public string Vardiya { get; set; } = null!;
    }
}
