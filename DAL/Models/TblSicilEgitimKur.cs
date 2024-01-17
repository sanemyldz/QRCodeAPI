using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilEgitimKur
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string EgitimKurs { get; set; } = null!;
        public string EgitimKursYeri { get; set; } = null!;
        public DateTime BaslangicTarih { get; set; }
        public DateTime BitisTarih { get; set; }
        public string? Notu { get; set; }
        public string? Aciklama { get; set; }
    }
}
