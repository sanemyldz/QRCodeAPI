using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TatilTipleri
    {
        public TatilTipleri()
        {
            Tatillers = new HashSet<Tatiller>();
        }

        public int Id { get; set; }
        public string Aciklama { get; set; } = null!;
        public bool? Tamgun { get; set; }
        public bool SabitTatil { get; set; }
        public string? Kod { get; set; }
        public int? Bassaat { get; set; }
        public DateTime? Gun { get; set; }
        public bool? YarimGunTatilOtomatikMesaiDevamsizYaz { get; set; }
        public bool? OrtusenHesaplama { get; set; }

        public virtual ICollection<Tatiller> Tatillers { get; set; }
    }
}
