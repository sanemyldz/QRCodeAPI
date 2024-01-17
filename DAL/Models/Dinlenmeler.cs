using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Dinlenmeler
    {
        public Dinlenmeler()
        {
            DinlenmeAtamalaris = new HashSet<DinlenmeAtamalari>();
        }

        public int Id { get; set; }
        public bool FazlaMesai { get; set; }
        public int Limit { get; set; }
        public string? Aciklama { get; set; }
        public bool? Opsiyonel { get; set; }
        public int Sure { get; set; }
        public bool? Duzensiz { get; set; }
        public int Baslama { get; set; }
        public int Bitis { get; set; }
        public bool Esnek { get; set; }
        public int? EsneklikBaslangici { get; set; }
        public int? EsneklikBitisi { get; set; }
        public int? EsnekDinlenmeFazlaKullanmaToleransi { get; set; }

        public virtual ICollection<DinlenmeAtamalari> DinlenmeAtamalaris { get; set; }
    }
}
