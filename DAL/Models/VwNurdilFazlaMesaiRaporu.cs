using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwNurdilFazlaMesaiRaporu
    {
        public int SicilId { get; set; }
        public string SicilNo { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string MesaiAciklama { get; set; } = null!;
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int FazlaMesai { get; set; }
        public int FazlaMesai150 { get; set; }
        public int FazlaMesai175 { get; set; }
        public int BolumId { get; set; }
        public int GorevId { get; set; }
        public int FirmaId { get; set; }
        public int PozisyonId { get; set; }
        public int MesaiSuresi { get; set; }
        public int Mesaibirimi { get; set; }
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
        public int NormalMesai { get; set; }
    }
}
