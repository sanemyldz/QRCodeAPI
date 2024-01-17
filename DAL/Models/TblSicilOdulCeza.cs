using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilOdulCeza
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string? Tipi { get; set; }
        public string? Turu { get; set; }
        public DateTime Tarih { get; set; }
        public string? Aciklama { get; set; }
        public decimal Miktari { get; set; }
    }
}
