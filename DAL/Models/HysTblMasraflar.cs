using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HysTblMasraflar
    {
        public int Id { get; set; }
        public int TalepId { get; set; }
        public int MasrafTuru { get; set; }
        public int OdemeSekli { get; set; }
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; } = null!;
        public DateTime Tarih { get; set; }

        public virtual HysTblMasrafTuru MasrafTuruNavigation { get; set; } = null!;
        public virtual HysTblOdemeSekli OdemeSekliNavigation { get; set; } = null!;
        public virtual HysTblMasrafTalepleri Talep { get; set; } = null!;
    }
}
