using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwIlkGirisSonCikisRaporu
    {
        public int SicilId { get; set; }
        public string SicilNo { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string Tcno { get; set; } = null!;
        public int FirmaId { get; set; }
        public string FirmaAd { get; set; } = null!;
        public int BolumId { get; set; }
        public string BolumAd { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAd { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAd { get; set; } = null!;
        public int BirimId { get; set; }
        public string BirimAd { get; set; } = null!;
        public DateTime MesaiTarih { get; set; }
        public DateTime IlkGiris { get; set; }
        public string IlkGirisTerminal { get; set; } = null!;
        public DateTime IlkCikis { get; set; }
        public string IlkCikisTerminal { get; set; } = null!;
        public int MesaiId { get; set; }
        public bool OncekiGunMesaisi { get; set; }
    }
}
