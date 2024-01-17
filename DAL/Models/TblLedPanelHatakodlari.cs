using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblLedPanelHatakodlari
    {
        public int Id { get; set; }
        public int? EventNameId { get; set; }
        public string? LedPanelAciklama { get; set; }
        public string? KullaniciAciklama { get; set; }
    }
}
