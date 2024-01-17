using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblOnaylananFazlaMesai
    {
        public int Id { get; set; }
        public int TasnifId { get; set; }
        public int OnaylananSure { get; set; }
        public bool IslemYapildi { get; set; }
    }
}
