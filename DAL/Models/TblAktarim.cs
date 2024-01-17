using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblAktarim
    {
        public int Id { get; set; }
        public string? Adi { get; set; }
        public string? Soyad { get; set; }
        public string? SicilNo { get; set; }
        public DateTime? GirisTar { get; set; }
        public DateTime? CikisTar { get; set; }
        public string? Firma { get; set; }
        public string? Bolum { get; set; }
        public string? Gorev { get; set; }
        public string? Pozisyon { get; set; }
        public string? CardId { get; set; }
        public string? FacilityCode { get; set; }
        public string? TcKimlikNo { get; set; }
    }
}
