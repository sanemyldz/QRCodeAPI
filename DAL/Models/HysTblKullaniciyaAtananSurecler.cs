using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HysTblKullaniciyaAtananSurecler
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int Surec0Id { get; set; }
        public int Surec1Id { get; set; }

        public virtual Sicil Sicil { get; set; } = null!;
        public virtual HysTblOnaySurecleri Surec0 { get; set; } = null!;
        public virtual HysTblOnaySurecleri Surec1 { get; set; } = null!;
    }
}
