using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSonKapiDurum
    {
        public int Id { get; set; }
        public int? TerminalId { get; set; }
        public DateTime? SonKapiIslemi { get; set; }
        public string? SonKapiDurumu { get; set; }
        public bool? UzunSureAcikKaldi { get; set; }
        public bool? KapiAcik { get; set; }
    }
}
