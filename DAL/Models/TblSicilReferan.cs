using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilReferan
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string? ReferansAdi { get; set; }
        public string? ReferansSoyadi { get; set; }
        public string? ReferansUnvani { get; set; }
        public DateTime? ReferansTarihi { get; set; }
        public string? ReferansTel { get; set; }
        public string? ReferansAdres { get; set; }
    }
}
