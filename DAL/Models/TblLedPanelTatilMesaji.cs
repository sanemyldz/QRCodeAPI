using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblLedPanelTatilMesaji
    {
        public int Id { get; set; }
        public int LedPanelId { get; set; }
        public DateTime BasTar { get; set; }
        public DateTime SonTar { get; set; }
        public string? MesajBir { get; set; }
        public string? MesajIki { get; set; }
        public string? MesajUc { get; set; }
        public string? MesajDort { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
