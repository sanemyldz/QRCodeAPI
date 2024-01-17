using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilResimKayit
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public byte[]? Resim { get; set; }
    }
}
