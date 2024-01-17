using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectPdk
    {
        public int Sure { get; set; }
        public int TasnifId { get; set; }
        public DateTime CikisTarih { get; set; }
        public DateTime MesaiTarih { get; set; }
        public DateTime Giris { get; set; }
        public int SicilId { get; set; }
        public string Cikis { get; set; } = null!;
        public int GirisKayitTipi { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public int GirisFark { get; set; }
        public int CikisFark { get; set; }
        public string? GecDurum { get; set; }
        public string? ErkenDurum { get; set; }
        public string? MesaiAciklama { get; set; }
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string? Okod1 { get; set; }
        public string? Okod2 { get; set; }
        public string? Okod3 { get; set; }
        public string? Okod4 { get; set; }
        public string? Okod5 { get; set; }
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string? PersonelNo { get; set; }
        public int BirimId { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public string? MesaiGrubAciklamasi { get; set; }
        public string? MesaiGrubAciklama { get; set; }
        public string IzinDurum { get; set; } = null!;
        public string? TatilDurum { get; set; }
        public int MesaiId { get; set; }
        public int Tatil { get; set; }
        public int ResmiTatil { get; set; }
        public int IzinId { get; set; }
        public string? BirimAdi { get; set; }
        public int? UcretliIzinMesai { get; set; }
        public string? IzinAciklama { get; set; }
        public int FazlaCalisma { get; set; }
        public int EksikCalisma { get; set; }
    }
}
