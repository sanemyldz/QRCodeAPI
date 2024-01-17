using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSysTerminalUrunGrubu
    {
        public TblSysTerminalUrunGrubu()
        {
            TblTerminalUrunGrubus = new HashSet<TblTerminalUrunGrubu>();
        }

        public int Id { get; set; }
        public string UrunGrubu { get; set; } = null!;

        public virtual ICollection<TblTerminalUrunGrubu> TblTerminalUrunGrubus { get; set; }
    }
}
