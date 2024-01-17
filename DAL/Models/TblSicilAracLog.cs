using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilAracLog
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int AracSicilId { get; set; }
        public string AracPlaka { get; set; } = null!;
        public string? RuhsatNo { get; set; }
        public string? Aciklama { get; set; }
        public string? CepTelefonu { get; set; }
        public int LoginUserId { get; set; }
        public int IslemTipId { get; set; }
        public DateTime IslemDatetime { get; set; }
        public string? Marka { get; set; }
        public string? Model { get; set; }
    }
}
