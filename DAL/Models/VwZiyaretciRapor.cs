using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwZiyaretciRapor
    {
        public bool? Sicil1IceriDurum { get; set; }
        public bool? Sicil2IceriDurum { get; set; }
        public string GirisStr { get; set; } = null!;
        public string CikisStr { get; set; } = null!;
        public string TarihStr { get; set; } = null!;
        public bool? Yasakli { get; set; }
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string KullaniciAdi { get; set; } = null!;
        public int GorevliId { get; set; }
        public string Kime { get; set; } = null!;
        public int SicilId1 { get; set; }
        public string SicilId1info { get; set; } = null!;
        public int SicilId2 { get; set; }
        public string SicilId2info { get; set; } = null!;
        public string SicilId3 { get; set; } = null!;
        public string ZiyaretNedeni { get; set; } = null!;
        public int ZiyaretTipi { get; set; }
        public string Plaka { get; set; } = null!;
        public string BolumAdiBir { get; set; } = null!;
        public string BolumAdiIki { get; set; } = null!;
        public string BirimAdi { get; set; } = null!;
        public string LoginName { get; set; } = null!;
        public int LoginId { get; set; }
        public string Firma { get; set; } = null!;
        public string TcKimlikNo { get; set; } = null!;
        public string ResimId { get; set; } = null!;
        public string LokasyonAdi { get; set; } = null!;
        public DateTime? Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public string Bilgi { get; set; } = null!;
        public int BirimId { get; set; }
        public string DogumYeri { get; set; } = null!;
        public DateTime? DogumTarih { get; set; }
        public string RuhsatSeriNo { get; set; } = null!;
        public string SurucuBelgeNo { get; set; } = null!;
        public string Kadi { get; set; } = null!;
        public int Kid { get; set; }
        public string Pozisyon { get; set; } = null!;
        public string ZiyaretciKartAdi { get; set; } = null!;
        public string Uyruk { get; set; } = null!;
        public string Aciklama { get; set; } = null!;
        public string HesCode { get; set; } = null!;
        public string SicilNo { get; set; } = null!;
        public string IlkTerminalName { get; set; } = null!;
        public string SonTerminalName { get; set; } = null!;
        public DateTime? IlkKartOkuma { get; set; }
        public DateTime? SonKartOkuma { get; set; }
    }
}
