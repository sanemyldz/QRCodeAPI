using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CboFirma
    {
        public CboFirma()
        {
            Sicils = new HashSet<Sicil>();
        }

        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public byte[]? Logo { get; set; }
        public string? FirmaKodu { get; set; }
        public bool? GlobalSicilIdgerekli { get; set; }

        public virtual ICollection<Sicil> Sicils { get; set; }
    }
}
