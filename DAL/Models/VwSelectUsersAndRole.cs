using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectUsersAndRole
    {
        public int? BirimId { get; set; }
        public bool ParmakIziIslem { get; set; }
        public bool Aktiflik { get; set; }
        public int SicilId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? SicilNo { get; set; }
        public string UserName { get; set; } = null!;
        public string RoleName { get; set; } = null!;
        public bool KartTanim { get; set; }
        public bool PlakaTanim { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public bool FirmaTanim { get; set; }
        public bool BolumTanim { get; set; }
        public bool PozisyonTanim { get; set; }
        public bool LokasyonTanim { get; set; }
        public bool BirimDegistirme { get; set; }
        public bool LedPanelTanimIslemi { get; set; }
        public bool UnvanTanim { get; set; }
        public bool StatuTanim { get; set; }
        public bool TaseronFirmaTanim { get; set; }
        public bool SirketTanim { get; set; }
        public bool SgkbilgiTanim { get; set; }
        public bool CalismaTipTanim { get; set; }
        public bool IsCikisNedeni { get; set; }
        public bool IsCikisNedeniSgk { get; set; }
        public bool GorevliTanim { get; set; }
        public bool KonteynerTanim { get; set; }
        public bool KisitlaManuelKayit { get; set; }
        public bool KisitlaIzinGiris { get; set; }
        public bool KisitlaVardiyaAtama { get; set; }
        public bool KisitlaIceridekiPersonelButtonYetki { get; set; }
        public bool KisitlaMesaiIzinAktarim { get; set; }
        public bool TumRaporYetki { get; set; }
        public bool TumFirmaYetki { get; set; }
        public bool TumLokasyonYetki { get; set; }
        public bool TumPeriyodYetki { get; set; }
        public bool TumTerminalYetki { get; set; }
        public bool TumYetkiGrubuYetki { get; set; }
        public bool ErisimKisiti { get; set; }
        public int YanlisDenemeTekrar { get; set; }
        public bool Oskad { get; set; }
    }
}
