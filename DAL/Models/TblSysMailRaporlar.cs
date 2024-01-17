using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSysMailRaporlar
    {
        public TblSysMailRaporlar()
        {
            TblMailYetkiliRaporlars = new HashSet<TblMailYetkiliRaporlar>();
        }

        public int Id { get; set; }
        public string? RaporDosyaAdi { get; set; }
        public string? RaporBosText { get; set; }
        public string? RaporDoluText { get; set; }
        public string? RaporKodu { get; set; }
        public string? RaporAdi { get; set; }
        public int? Tip { get; set; }
        public bool? YeniSistem { get; set; }
        public bool? MailIcerik { get; set; }
        public bool? Ek { get; set; }
        public int? OncekiGunSayisi { get; set; }
        public string? MailKonuSablonu { get; set; }
        public int? GunlukOncekiGunSayisi { get; set; }
        public bool? Filtreleme { get; set; }
        public bool? MesaiTarihineGoreFiltreleme { get; set; }
        public bool? Aktif { get; set; }
        public bool? IsaretsizGunSayısıKadarGeriyeGit { get; set; }

        public virtual ICollection<TblMailYetkiliRaporlar> TblMailYetkiliRaporlars { get; set; }
    }
}
