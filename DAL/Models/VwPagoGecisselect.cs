using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwPagoGecisselect
    {
        public int PdksRecordId { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? PersonelNo { get; set; }
        public string? CardId { get; set; }
        public string? FacilityCode { get; set; }
        public int TerminalId { get; set; }
        public string Name { get; set; } = null!;
        public string Yon { get; set; } = null!;
        public DateTime EventTime { get; set; }
        public DateTime BildirimTarihi { get; set; }
        public int? Aktarildi { get; set; }
    }
}
