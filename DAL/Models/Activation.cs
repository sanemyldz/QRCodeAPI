using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Activation
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public bool? Aktif { get; set; }
        public bool? Yasakla { get; set; }
    }
}
