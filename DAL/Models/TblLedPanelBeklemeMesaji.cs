using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblLedPanelBeklemeMesaji
    {
        public int Id { get; set; }
        public int? LedPanelId { get; set; }
        public string? MesajBir { get; set; }
        public string? MesajIki { get; set; }
        public string? MesajUc { get; set; }
        public string? MesajDort { get; set; }
    }
}
