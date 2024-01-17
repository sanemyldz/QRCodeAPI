using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwTimeSheetReport
    {
        public int Id { get; set; }
        public int TasnifId { get; set; }
        public int SicilId { get; set; }
        public string SicilNo { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int BolumId { get; set; }
        public int GorevId { get; set; }
        public int FirmaId { get; set; }
        public int BirimId { get; set; }
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public int MesaiId { get; set; }
        public int MesaiSuresi { get; set; }
        public string Aciklama { get; set; } = null!;
        public string TypeOfHourseWorked { get; set; } = null!;
    }
}
