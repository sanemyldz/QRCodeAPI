using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwHaftalikCalismaSureleriMail
    {
        public int Id { get; set; }
        public string SicilNo { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int TotalIceridekiSure { get; set; }
        public int? IzinIdList { get; set; }
        public string IzinAciklama { get; set; } = null!;
        public int SicilId { get; set; }
        public int BolumId { get; set; }
        public int BirimId { get; set; }
        public int FirmaId { get; set; }
        public int MesaiSuresi { get; set; }
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
    }
}
