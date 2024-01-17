using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilDosyalar
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string? DosyaTipi { get; set; }
        public string? DosyaYolu { get; set; }
        public string? Aciklama { get; set; }
    }
}
