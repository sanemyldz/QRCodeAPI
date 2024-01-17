using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilDetay
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int? CalismaTipId { get; set; }
        public string? Cinsiyet { get; set; }
        public int? StatuId { get; set; }
        public int? UnvanId { get; set; }
        public int? TaseronFirmaId { get; set; }
        public int? Sgkid { get; set; }
        public string? DogumYeri { get; set; }
        public string? AcilDurum { get; set; }
        public string? KanGrubu { get; set; }
        public string? Egitim { get; set; }
        public int? SirketId { get; set; }
        public int? IsCikisNedeni { get; set; }
        public int? IsCikisNedeniSgk { get; set; }
        public string? GorevTuru { get; set; }
        public string? AcilDurumTel { get; set; }
        public string? Gorev { get; set; }
    }
}
