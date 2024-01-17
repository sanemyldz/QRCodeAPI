using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AnketSonuc
    {
        public int Id { get; set; }
        public int AnketId { get; set; }
        public int SoruId { get; set; }
        public int CevapId { get; set; }
        public int SicilId { get; set; }
        public DateTime Tarih { get; set; }

        public virtual AnketTanim Anket { get; set; } = null!;
        public virtual AnketSoruCevap Cevap { get; set; } = null!;
        public virtual Sicil Sicil { get; set; } = null!;
        public virtual AnketSoru Soru { get; set; } = null!;
    }
}
