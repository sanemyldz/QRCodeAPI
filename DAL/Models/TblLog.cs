using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int IslemId { get; set; }
        public string IslemAciklama { get; set; } = null!;
        public DateTime Tarih { get; set; }
    }
}
