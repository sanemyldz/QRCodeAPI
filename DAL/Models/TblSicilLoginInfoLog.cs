using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilLoginInfoLog
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int UserLoginId { get; set; }
        public int RoleId { get; set; }
        public bool ParmakIziIslem { get; set; }
        public bool Aktiflik { get; set; }
        public bool PlakaTanim { get; set; }
        public bool KartTanim { get; set; }
        public int LoginUserId { get; set; }
        public int IslemTipId { get; set; }
        public DateTime IslemDatetime { get; set; }
        public int SicilLoginInfoId { get; set; }
        public bool? FirmaTanim { get; set; }
        public bool? BolumTanim { get; set; }
        public bool? PozisyonTanim { get; set; }
        public bool? LokasyonTanim { get; set; }
        public bool? BirimDegistirme { get; set; }
        public bool? LedPanelTanimIslemi { get; set; }
        public bool? UnvanTanim { get; set; }
        public bool? StatuTanim { get; set; }
        public bool? TaseronFirmaTanim { get; set; }
        public bool? SirketTanim { get; set; }
        public bool? SgkbilgiTanim { get; set; }
        public bool? CalismaTipTanim { get; set; }
        public bool? IsCikisNedeni { get; set; }
        public bool? IsCikisNedeniSgk { get; set; }
        public bool? GorevliTanim { get; set; }
    }
}
