using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwArgeAraGeci
    {
        public int TasnifId { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public int IceridekiSure { get; set; }
        public DateTime? PoolGiris { get; set; }
        public DateTime? PoolCikis { get; set; }
        public int? GirisTerminalId { get; set; }
        public string GirisTerminal { get; set; } = null!;
        public int? CikisTerminalId { get; set; }
        public string CikisTerminal { get; set; } = null!;
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string Tcno { get; set; } = null!;
        public int BirimId { get; set; }
        public string BirimAd { get; set; } = null!;
        public int FirmaId { get; set; }
        public string FirmaAd { get; set; } = null!;
        public int BolumId { get; set; }
        public string BolumAd { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAd { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAd { get; set; } = null!;
    }
}
