using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblHaritaSubeMarker
    {
        public int Id { get; set; }
        public int SubeKrokiId { get; set; }
        public int TerminalId { get; set; }
        public int Xaxis { get; set; }
        public int Yaxis { get; set; }
    }
}
