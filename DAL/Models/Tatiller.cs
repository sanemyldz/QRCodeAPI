using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Tatiller
    {
        public int Id { get; set; }
        public int TatilId { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; } = null!;

        public virtual TatilTipleri Tatil { get; set; } = null!;
    }
}
