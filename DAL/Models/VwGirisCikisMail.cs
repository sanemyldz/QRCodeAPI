using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGirisCikisMail
    {
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int BirimId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string FirmaAd { get; set; } = null!;
        public int MesaiBaslangic { get; set; }
        public int MesaiBitis { get; set; }
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
        public int IzinId { get; set; }
        public string IzinAdi { get; set; } = null!;
        public string IzinAciklama { get; set; } = null!;
        public bool Saatlikizin { get; set; }
        public DateTime BaslangicTarih { get; set; }
        public DateTime BitisTarih { get; set; }
    }
}
