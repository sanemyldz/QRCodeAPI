using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblHesaplayiciAyar
    {
        public int Id { get; set; }
        public int? TekCihazGuncellemeAralik { get; set; }
        public int? TekCihazGeriyeDonukGunSayi { get; set; }
        public int? CiftCihazGuncellemeAralik { get; set; }
        public int? CiftCihazGeriyeDonukGunSayi { get; set; }
        public int? SerbestMesaiHesapGuncellemeAralik { get; set; }
        public int? SerbestMesaiGeriyeDonukGunSayi { get; set; }
        public bool? DinlenmeSureHesapAktif { get; set; }
        public bool? OdaIceriSureAktif { get; set; }
        public bool? ManuelGecisHesapOncelikli { get; set; }
        public bool? HesKodSorgulamaAktif { get; set; }
        public int? HesKodSorguZamanAralik { get; set; }
        public bool? KesitliCalismaHesaplamaAktif { get; set; }
        public int MailSure { get; set; }
    }
}
