using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAylikVardiyaListesi
    {
        public int Id { get; set; }
        public DateTime MesaiTarih { get; set; }
        public string TanimliMesai { get; set; } = null!;
        public int MesaiId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string TcNo { get; set; } = null!;
        public int SicilId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public int BirimId { get; set; }
        public DateTime IlkGiris { get; set; }
        public DateTime SonCikis { get; set; }
        public int TasnifId { get; set; }
        public int Gorev { get; set; }
        public string Gerceklesen { get; set; } = null!;
    }
}
