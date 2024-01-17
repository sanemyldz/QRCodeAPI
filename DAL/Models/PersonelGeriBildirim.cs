using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PersonelGeriBildirim
    {
        public int Id { get; set; }
        public int Olusturan { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public byte AygitTuru { get; set; }
        public byte Tip { get; set; }
        public string Konu { get; set; } = null!;
        public string Aciklama { get; set; } = null!;
        public string? ImgPath { get; set; }
        public DateTime? TerminTarihi { get; set; }
        public byte Durum { get; set; }
        public bool Deleted { get; set; }
    }
}
