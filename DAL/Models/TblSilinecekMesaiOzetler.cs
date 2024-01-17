using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSilinecekMesaiOzetler
    {
        public int Id { get; set; }
        public int MesaiOzetId { get; set; }
        public int TasnifId { get; set; }
    }
}
