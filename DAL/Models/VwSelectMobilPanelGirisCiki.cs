using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectMobilPanelGirisCiki
    {
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateTime KomutTarihi { get; set; }
        public string? KomutGrupAdi { get; set; }
        public string KomutAdi { get; set; } = null!;
        public string? Yon { get; set; }
    }
}
