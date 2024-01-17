using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SicilFoto
    {
        public int Sicilid { get; set; }
        public byte[]? Fotoimage { get; set; }
        public DateTime? Recorddate { get; set; }
        public int? Xsicilid { get; set; }
        public int? Compressed { get; set; }
        public string? Level { get; set; }
    }
}
