using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectUserLog
    {
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string IslemAciklama { get; set; } = null!;
        public DateTime Tarih { get; set; }
        public int Id { get; set; }
        public string? IslemAdi { get; set; }
        public string UserName { get; set; } = null!;
        public int UserId { get; set; }
    }
}
