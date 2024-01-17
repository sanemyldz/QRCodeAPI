using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblLedPanelBeklemeMesajiLog
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? IslemZamani { get; set; }
        public int? PanelId { get; set; }
        public string? MesajBir { get; set; }
        public string? MesajIki { get; set; }
        public string? MesajUc { get; set; }
        public string? MesajDort { get; set; }
    }
}
