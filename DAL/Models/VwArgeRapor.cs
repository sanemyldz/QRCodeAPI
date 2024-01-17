using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwArgeRapor
    {
        public int MesaiSuresi { get; set; }
        public int SicilId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int? Yil { get; set; }
        public int Ay { get; set; }
        public int Gun { get; set; }
        public int Hafta { get; set; }
        public DateTime Tarih { get; set; }
        public int Direktorluk { get; set; }
        public DateTime Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public int GirisMin { get; set; }
        public int NormalMesai { get; set; }
        public int ResmiTatil { get; set; }
        public int ResmiTatilMesai { get; set; }
        public int FazlaMesai { get; set; }
        public int BirimId { get; set; }
        public string? BirimAdi { get; set; }
        public int GorevId { get; set; }
        public int BolumId { get; set; }
        public int PozisyonId { get; set; }
    }
}
