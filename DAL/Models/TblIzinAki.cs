using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblIzinAki
    {
        public int Id { get; set; }
        public string Aciklama { get; set; } = null!;
        public int OnaySayi { get; set; }
        public bool Deleted { get; set; }
    }
}
