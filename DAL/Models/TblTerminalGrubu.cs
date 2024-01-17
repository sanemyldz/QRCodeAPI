using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblTerminalGrubu
    {
        public int Id { get; set; }
        public int? GrupId { get; set; }
        public int? TerminalId { get; set; }
    }
}
