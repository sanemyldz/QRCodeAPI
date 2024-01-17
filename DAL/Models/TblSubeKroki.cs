using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSubeKroki
    {
        public int Id { get; set; }
        public int? KurulusId { get; set; }
        public int? DaireId { get; set; }
        public string? KrokiAdi { get; set; }
        public int? KatNo { get; set; }
        public string? KrokiImage { get; set; }
    }
}
