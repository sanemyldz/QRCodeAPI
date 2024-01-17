using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblWcgirisCiki
    {
        public int Id { get; set; }
        public DateTime? Wcgiris { get; set; }
        public DateTime? Wccikis { get; set; }
        public int SicilId { get; set; }
        public string? TerminalAdiGiris { get; set; }
        public string? TerminalAdiCikis { get; set; }
        public DateTime? MesaiTarih { get; set; }
    }
}
