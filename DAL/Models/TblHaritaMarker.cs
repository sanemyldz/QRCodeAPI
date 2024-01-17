using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblHaritaMarker
    {
        public int Id { get; set; }
        public int HaritaId { get; set; }
        public int TerminalId { get; set; }
        public int Xaxis { get; set; }
        public int Yaxis { get; set; }
    }
}
