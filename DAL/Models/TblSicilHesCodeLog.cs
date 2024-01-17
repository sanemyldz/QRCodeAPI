using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilHesCodeLog
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string HesCode { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public int SaglikDurum { get; set; }
    }
}
