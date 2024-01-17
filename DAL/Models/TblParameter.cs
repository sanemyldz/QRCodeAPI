using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblParameter
    {
        public int Id { get; set; }
        public bool? TcNoZorunlu { get; set; }
        public bool? ZiyaretciKartBasim { get; set; }
        public bool? ZiyaretNedeniSorma { get; set; }
        public bool ZiyaretciLokasyonYapisi { get; set; }
        public bool ManuelTolerans { get; set; }
        public bool EmekliPersonelGoster { get; set; }
        public bool IceriSureHesaplama { get; set; }
        public int? F1 { get; set; }
        public int? F2 { get; set; }
        public int? F3 { get; set; }
        public int? F4 { get; set; }
        public int BelirliGunYasakla { get; set; }
        public int? MesaiAlgoritmaId { get; set; }
        public bool TumBirimGoster { get; set; }
        public bool? SicilBilgiDetay { get; set; }
        public bool? LedPanelModuluAktif { get; set; }
        public bool? IzinBilgiDetay { get; set; }
        public int? SicilEklemeTipi { get; set; }
        public bool? ZiyaretciFotoCekimi { get; set; }
        public bool? KonteynerYonetimiAktif { get; set; }
        public bool? MymEntegrasyon { get; set; }
        public bool? SicilYemekhane { get; set; }
        public bool? SicilYolUcret { get; set; }
        public bool? IzinOnayGerekli { get; set; }
        public int? SayfaBasinaKayitSayisi { get; set; }
        public bool? RaporParametreSifirla { get; set; }
        public bool? IceridekiPersonelButton { get; set; }
        public bool? IzinTalepSinirla { get; set; }
        public string? IzinTalepTip { get; set; }
        public int? IzinTalepMaxMiktar { get; set; }
        public string? YenilemeZamani { get; set; }
        public bool? DevirEdilsin { get; set; }
        public bool? DinamikZiyaretciKartYetki { get; set; }
        public bool? TakvimIzinBakiye { get; set; }
        public bool? ZiyaretEdilenFirmaBazli { get; set; }
        public bool? IzinTalepAciklamaZorunlu { get; set; }
        public bool? Kvkk { get; set; }
        public int? Kvkkformat { get; set; }
        public bool? OtomatikKartFormatCevir { get; set; }
        public int? KartNoCevirmeTipId { get; set; }
        public bool? YanlisGirisErisimKisitla { get; set; }
        public int? YanlisGirisSayisi { get; set; }
        public bool? SifreYenile { get; set; }
        public int? SifreYenilemePeriyodu { get; set; }
        public bool? EskiYeniSifreFarkli { get; set; }
        public bool? GucluSifreOlustur { get; set; }
    }
}
