using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwOdaKalinanSure
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int SicilId { get; set; }
        public int GirisTerminalId { get; set; }
        public int CikisTerminalId { get; set; }
        public int FirmaId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int BirimId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public string OdaAdi { get; set; } = null!;
        public int OdaId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public DateTime GirisZamani { get; set; }
        public string GirisTerminali { get; set; } = null!;
        public DateTime CikisZamani { get; set; }
        public string CikisTerminali { get; set; } = null!;
        public decimal Sure { get; set; }
        public string PersonelNo { get; set; } = null!;
    }
}
