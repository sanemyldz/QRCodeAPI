using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblOzlukGorevlendirme
    {
        public int Id { get; set; }
        public int? Sicil { get; set; }
        public int? OzlukGorevId { get; set; }
        public DateTime? BaslangicTarih { get; set; }
        public DateTime? BitisTarih { get; set; }
        public int? Harcirah { get; set; }
        public int? ParaBirimiId { get; set; }
        public int? OzlukGorevYeriId { get; set; }
        public int? OzlukGorevBolumId { get; set; }
        public string? Aciklama { get; set; }
        public string? KonaklamaTipi { get; set; }
        public string? Dosya { get; set; }
    }
}
