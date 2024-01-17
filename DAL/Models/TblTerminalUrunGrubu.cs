using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblTerminalUrunGrubu
    {
        public int Id { get; set; }
        public int TerminalId { get; set; }
        public int UrunGrupId { get; set; }

        public virtual Terminaller Terminal { get; set; } = null!;
        public virtual TblSysTerminalUrunGrubu UrunGrup { get; set; } = null!;
    }
}
