using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwRonesansKartBaskiReadSicil
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string GorevAdi { get; set; } = null!;
        public string FirmaAdi { get; set; } = null!;
        public byte[]? ResimYol { get; set; }
        public string KanGrubu { get; set; } = null!;
        public int SirketId { get; set; }
        public string Okod1 { get; set; } = null!;
        public string PozisyonAdi { get; set; } = null!;
        public string BirimAdi { get; set; } = null!;
        public string BolumAdi { get; set; } = null!;
        public string KartNo { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public int UserDef { get; set; }
        public string Tcno { get; set; } = null!;
        public int GorevId { get; set; }
        public int FirmaId { get; set; }
        public string FirmaKodu { get; set; } = null!;
        public int PozisyonId { get; set; }
        public int BirimId { get; set; }
        public int BolumId { get; set; }
        public string Okod2 { get; set; } = null!;
        public DateTime DogumTarih { get; set; }
        public string BabaAdi { get; set; } = null!;
        public string AnneAdi { get; set; } = null!;
        public string DogumYeri { get; set; } = null!;
        public string Il { get; set; } = null!;
        public string Ilce { get; set; } = null!;
        public string Okod3 { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string AmirAd { get; set; } = null!;
        public DateTime GirisTarih { get; set; }
    }
}
