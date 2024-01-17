using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwInterdataNetMesaiRapor
    {
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string BirimAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public int PozisyonId { get; set; }
        public int BolumId { get; set; }
        public int GorevId { get; set; }
        public int BirimId { get; set; }
        public int IceridekiSure { get; set; }
        public int ToplamMesaiSure { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int SicilId { get; set; }
        public string SicilNo { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
        public int? ToplamIzinSure { get; set; }
    }
}
