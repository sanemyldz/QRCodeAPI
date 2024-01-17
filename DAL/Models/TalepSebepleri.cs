using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TalepSebepleri
    {
        public int Id { get; set; }
        public string Sebep { get; set; } = null!;
        public int Tip { get; set; }
    }
}
