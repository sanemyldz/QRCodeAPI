using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwNurdilKisiBazliDevamsizlikRaporu
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime GirisTarih { get; set; }
        public DateTime CikisTarih { get; set; }
        public int GirisKayitTipi { get; set; }
        public int CikisKayitTipi { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public string MesaiAciklama { get; set; } = null!;
        public string İzinTipAciklama { get; set; } = null!;
        public string IzinAciklama { get; set; } = null!;
        public int BirimId { get; set; }
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int PozisyonId { get; set; }
        public int GorevId { get; set; }
        public int IzinId { get; set; }
        public int IzinTipId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int Tatil { get; set; }
        public string SicilNo { get; set; } = null!;
        public int MesaiId { get; set; }
    }
}
