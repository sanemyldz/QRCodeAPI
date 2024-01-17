using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblTasnifLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? TasnifId { get; set; }
        public DateTime? IslemDate { get; set; }
        public string? IslemAciklama { get; set; }
    }
}
