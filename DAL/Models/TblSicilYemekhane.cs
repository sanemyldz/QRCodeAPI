using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilYemekhane
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public int? YemekhaneBilgiId { get; set; }
        public int? TerminalId { get; set; }
        public DateTime? BaslangicTarih { get; set; }
        public DateTime? BitisTarih { get; set; }
        public int? MesaiId { get; set; }

        public virtual Sicil? Sicil { get; set; }
        public virtual Terminaller? Terminal { get; set; }
        public virtual TblYemekhaneBilgi? YemekhaneBilgi { get; set; }
    }
}
