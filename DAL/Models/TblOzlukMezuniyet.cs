using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblOzlukMezuniyet
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public int? OzlukOkulId { get; set; }
        public int? OzlukBolumId { get; set; }
        public int? OzlukAlanId { get; set; }
        public string? DiplomaNotu { get; set; }
        public string? MezuniyetTarih { get; set; }
    }
}
