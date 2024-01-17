using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGelmeyenlerEkAlan
    {
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string BirimAdi { get; set; } = null!;
        public int BirimId { get; set; }
        public string SicilNo { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public int SicilId { get; set; }
        public int BolumId { get; set; }
        public string MesaiAdi { get; set; } = null!;
        public string MesaiTarih { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public int Tolerans { get; set; }
        public int MesaiBas { get; set; }
        public int MesaiBit { get; set; }
    }
}
